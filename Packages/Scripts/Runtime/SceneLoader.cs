using System;
using Cysharp.Threading.Tasks;
using Enpiech.Core.Runtime.UI.Data;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Events;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Enpiech.SceneManagement.Runtime.ScriptableObjects;
using Enpiech.Utils.Runtime.Helper;
using NaughtyAttributes;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Enpiech.SceneManagement.Runtime
{
    /// <summary>
    ///     This class manages the scene loading and unloading.
    /// </summary>
    public sealed class SceneLoader : MonoBehaviour
    {
        [Foldout("Config")]
        [SerializeField]
        [Min(0)]
        private float _fadeDuration;

        [Foldout("Config")]
        [SerializeField]
        private GameSceneSO _gameplayManagerSceneSO = default!;

        [Foldout("Config")]
        [SerializeField]
        [Range(0, 1)]
        private float _loadedPercent = 0.95f;

        [Foldout("Listening to")]
        [SerializeField]
        private LoadSceneRequestEvent _loadGameplayLevelEvent = default!;

        [Foldout("Listening to")]
        [SerializeField]
        private LoadSceneRequestEvent _loadMenuEvent = default!;

        [Foldout("Listening to")]
        [SerializeField]
        private LoadSceneRequestEvent _coldStartEvent = default!;

        [Foldout("Broadcasting on")]
        [SerializeField]
        private BoolEvent _toggleLoadingEvent = default!;

        [Foldout("Broadcasting on")]
        [SerializeField]
        private FloatEvent _changeLoadingProgressEvent = default!;

        [Foldout("Broadcasting on")]
        [Tooltip("Picked up by the SpawnSystem")]
        [SerializeField]
        private VoidEvent _sceneReadyEvent = default!;

        [Foldout("Broadcasting on")]
        [SerializeField]
        private FadeEvent _fadeEvent = default!;

        /// <summary>
        ///     Would be null if the game was started in Initialization
        /// </summary>
        private GameSceneSO? _currentlyLoadedScene;

        private SceneInstance? _gameplayManagerSceneInstance;

        /// <summary>
        ///     To prevent a new loading request while already loading a new scene
        /// </summary>
        private bool _isLoading;

        /// <summary>
        ///     Parameters coming from scene loading requests
        /// </summary>
        private LoadSceneRequest? _loadSceneRequest;

#if UNITY_EDITOR
        private Action<LoadSceneRequest> _onLoadingColdStartupGameplayLevel = default!;
#endif
        private Action<LoadSceneRequest>? _onLoadingGameplayLevel;
        private Action<LoadSceneRequest>? _onLoadingMenu;

        private void OnEnable()
        {
            _onLoadingGameplayLevel = UniTaskHelper.Action<LoadSceneRequest>(OnLoadGameplayLevel);
            _loadGameplayLevelEvent.Register(_onLoadingGameplayLevel);

            _onLoadingMenu = UniTaskHelper.Action<LoadSceneRequest>(OnLoadMenu);
            _loadMenuEvent.Register(_onLoadingMenu);

#if UNITY_EDITOR
            _onLoadingColdStartupGameplayLevel = UniTaskHelper.Action<LoadSceneRequest>(OnGameplayLevelColdStartup);
            _coldStartEvent.Register(_onLoadingColdStartupGameplayLevel);
#endif
        }

        private void OnDisable()
        {
            _loadGameplayLevelEvent.Unregister(_onLoadingGameplayLevel);
            _loadMenuEvent.Unregister(_onLoadingMenu);
#if UNITY_EDITOR
            _coldStartEvent.Unregister(_onLoadingColdStartupGameplayLevel);
#endif
        }

#if UNITY_EDITOR
        /// <summary>
        ///     This special loading function is only used in the editor, when the developer presses Play in a Location scene,
        ///     without passing by Initialization.
        /// </summary>
        private async UniTaskVoid OnGameplayLevelColdStartup(LoadSceneRequest loadSceneRequest)
        {
            _currentlyLoadedScene = loadSceneRequest.SceneToLoad;

            if (_currentlyLoadedScene!.SceneType != GameSceneType.GameplayLevel)
            {
                return;
            }

            _gameplayManagerSceneInstance = await _gameplayManagerSceneSO.SceneReference.LoadSceneAsync(LoadSceneMode.Additive).ToUniTask();
            StartGameplay();
        }
#endif

        /// <summary>
        ///     This function loads the location scenes passed as array parameter
        /// </summary>
        private async UniTaskVoid OnLoadGameplayLevel(LoadSceneRequest request)
        {
            // Prevent a double-loading, for situations where the player falls in two Exit colliders in one frame
            if (_isLoading)
            {
                return;
            }

            _isLoading = true;
            _loadSceneRequest = request;

            // In case we are coming from the main menu, we need to load the Gameplay manager scene first
            if (_gameplayManagerSceneInstance is not { Scene: { isLoaded: not false } })
            {
                _gameplayManagerSceneInstance = await _gameplayManagerSceneSO.SceneReference.LoadSceneAsync(LoadSceneMode.Additive);
            }

            await UnloadPreviousScene();
        }

        /// <summary>
        ///     Prepares to load the main menu scene, first removing the Gameplay scene in case the game is coming back from
        ///     gameplay to menus.
        /// </summary>
        private async UniTaskVoid OnLoadMenu(LoadSceneRequest request)
        {
            // Prevent a double-loading, for situations where the player falls in two Exit colliders in one frame
            if (_isLoading)
            {
                return;
            }

            _isLoading = true;
            _loadSceneRequest = request;

            // In case we are coming from a Location back to the main menu, we need to get rid of the persistent Gameplay manager scene
            if (_gameplayManagerSceneInstance is { Scene: { isLoaded: true } })
            {
                await Addressables.UnloadSceneAsync(_gameplayManagerSceneInstance.Value);
            }

            await UnloadPreviousScene();
        }

        /// <summary>
        ///     In both Location and Menu loading, this function takes care of removing previously loaded scenes.
        /// </summary>
        private async UniTask UnloadPreviousScene()
        {
            _fadeEvent.Raise(Fade.Out(_fadeDuration));

            await UniTask.Delay(TimeSpan.FromSeconds(_fadeDuration));

            if (_currentlyLoadedScene != null)
            {
                if (_currentlyLoadedScene.SceneReference.OperationHandle.IsValid())
                {
                    /*
                     * Unload the scene through its AssetReference, i.e. through the Addressable system
                     * If reload scene case, wait until scene is completely unloaded before load it again
                     */
                    await _currentlyLoadedScene.SceneReference.UnLoadScene();
                }
#if UNITY_EDITOR
                else
                {
                    /*
                     * Only used when, after a "cold start", the player moves to a new scene
                     * Since the AsyncOperationHandle has not been used (the scene was already open in the editor),
                     * the scene needs to be unloaded using regular SceneManager instead of as an Addressable
                     */
                    await SceneManager.UnloadSceneAsync(_currentlyLoadedScene.SceneReference.editorAsset.name);
                }
#endif
            }

            LoadNewScene().Forget();
        }

        /// <summary>
        ///     Kicks off the asynchronous loading of a scene, either menu or Location.
        /// </summary>
        private async UniTaskVoid LoadNewScene()
        {
            if (!_loadSceneRequest.HasValue)
            {
                return;
            }

            if (_loadSceneRequest.Value.ShouldShowLoadingScreenOnLoading)
            {
                _toggleLoadingEvent.Raise(true);
                _changeLoadingProgressEvent.Raise(_loadSceneRequest.Value.LoadingPercent);
            }

            var loadSceneProgress = Progress.Create<float>(progress =>
            {
                if (progress <= _loadedPercent)
                {
                    _changeLoadingProgressEvent.Raise(progress / 2 + _loadSceneRequest.Value.LoadingPercent);
                }
            });
            await _loadSceneRequest.Value.SceneToLoad.SceneReference.LoadSceneAsync(LoadSceneMode.Additive)
                .ToUniTask(loadSceneProgress)
                .ContinueWith(sceneInstance => OnNewSceneLoaded(_loadSceneRequest.Value, sceneInstance));
        }

        private void OnNewSceneLoaded(LoadSceneRequest loadSceneRequest, SceneInstance sceneInstance)
        {
            // Save loaded scenes (to be unloaded at next load request)
            _currentlyLoadedScene = loadSceneRequest.SceneToLoad;

            var resultScene = sceneInstance.Scene;
            SceneManager.SetActiveScene(resultScene);
            LightProbes.TetrahedralizeAsync();

            _isLoading = false;

            _changeLoadingProgressEvent.Raise(loadSceneRequest.LoadedPercent);
            if (loadSceneRequest.ShouldHideLoadingScreenOnLoaded)
            {
                _toggleLoadingEvent.Raise(false);
            }

            _fadeEvent.Raise(Fade.In(_fadeDuration));

            StartGameplay();
        }

        private void StartGameplay()
        {
            _sceneReadyEvent.Raise();
        }

        private void ExitGame()
        {
            Application.Quit();
            Debug.Log("Exit!");
        }
    }
}