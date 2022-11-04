using Enpiech.Core.Runtime.Gameplay.Save;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Enpiech.SceneManagement.Runtime.ScriptableObjects;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace Enpiech.SceneManagement.Editor
{
    /// <summary>
    ///     Allows a "cold start" in the editor, when pressing Play and not passing from the Initialisation scene.
    /// </summary>
    public sealed class EditorColdStartUp : MonoBehaviour
    {
#if UNITY_EDITOR
        [Header("Config")]
        [SerializeField]
        private GameSceneSO _thisSceneSO = default!;

        [Header("References")]
        [SerializeField]
        private GameSceneSO _persistentManagersSO = default!;

        [SerializeField]
        private SaveSystem? _saveSystem;

        [Header("Broadcasting on")]
        [SerializeField]
        private LoadSceneRequestEvent _notifyColdStartupChannel = default!;

        [Header("Listening to")]
        [SerializeField]
        private VoidEvent _onSceneReadyChannel = default!;

        private bool _isColdStart;
        private Runtime.Data.LoadSceneRequest.LoadSceneRequest _loadSceneRequest = null!;

        private void Awake()
        {
            _loadSceneRequest = new Runtime.Data.LoadSceneRequest.LoadSceneRequest(_thisSceneSO);
            var persistentManagersSceneName = _persistentManagersSO.SceneReference.editorAsset.name;
            if (!SceneManager.GetSceneByName(persistentManagersSceneName).isLoaded)
            {
                _isColdStart = true;
            }
            CreateSaveFileIfNotPresent();
        }

        private void Start()
        {
            if (_isColdStart)
            {
                _persistentManagersSO.SceneReference.LoadSceneAsync(LoadSceneMode.Additive).CompletedTypeless += OnNotifyChannelLoaded;
            }
            CreateSaveFileIfNotPresent();
        }

        private void CreateSaveFileIfNotPresent()
        {
            if (_saveSystem != null && !_saveSystem.LoadSaveDataFromDisk())
            {
                _saveSystem.SetNewGameData();
            }
        }

        private void OnNotifyChannelLoaded(AsyncOperationHandle obj)
        {
            if (_thisSceneSO != null)
            {
                _notifyColdStartupChannel.Raise(_loadSceneRequest);
                return;
            }
            //Raise a fake scene ready event, so the player is spawned
            _onSceneReadyChannel.Raise();
            //When this happens, the player won't be able to move between scenes because the SceneLoader has no conception of which scene we are in
        }
#endif
    }
}