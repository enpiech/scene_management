using System;
using Cysharp.Threading.Tasks;
using Enpiech.SceneManagement.Runtime.Actions;
using Enpiech.SceneManagement.Runtime.ScriptableObjects;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Enpiech.SceneManagement.Runtime
{
    /// <summary>
    ///     This class is responsible for starting the game by loading the persistent managers scene
    ///     and raising the event to load the Login Menu
    /// </summary>
    public sealed class InitializationLoader : MonoBehaviour
    {
        [Header("Config")]
        [SerializeField]
        private GameSceneSO _managersScene = default!;

        [Header("Broadcasting on")]
        [SerializeField]
        private AssetReferenceT<LoadSceneAction> _loadMenuActionReference = default!;

        [SerializeField]
        private Slider? _slider;

        private void Start()
        {
            LoadLoadingScene().Forget();
        }

        private async UniTaskVoid LoadLoadingScene()
        {
            await LoadPersistentManagerScene();
        }

        private async UniTask LoadPersistentManagerScene()
        {
            var progress = 0f;
            var handler = _managersScene.SceneReference.LoadSceneAsync(LoadSceneMode.Additive, false);
            if (_slider != null)
            {
                _slider.value = 0;
                handler.Completed += _ => { _slider.value = _slider.maxValue; };
                while (progress < 0.9f)
                {
                    progress += 0.01f;
                    _slider.value = progress;
                    await UniTask.Delay(TimeSpan.FromSeconds(0.01f));
                }
            }
            await handler;
            await OnManagersSceneLoaded(handler.Result);
        }

        private async UniTask OnManagersSceneLoaded(SceneInstance scene)
        {
            await scene.ActivateAsync();
            await _loadMenuActionReference.LoadAssetAsync<LoadSceneAction>()
                .ToUniTask()
                .ContinueWith(action => action.Do())
                .ContinueWith(UnloadInitializationScene);
        }

        /// <summary>
        ///     Initialization is the only scene in BuildSettings, thus it has index 0
        /// </summary>
        private static void UnloadInitializationScene()
        {
            SceneManager.UnloadSceneAsync(0);
        }
    }
}