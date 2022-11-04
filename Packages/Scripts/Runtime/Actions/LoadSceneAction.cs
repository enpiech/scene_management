using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Enpiech.SceneManagement.Runtime.ScriptableObjects;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.SceneManagement.Runtime.Actions
{
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Scene Management/Load Scene", fileName = "AC_LoadScene")]
    public sealed class LoadSceneAction : AtomAction<GameSceneSO>
    {
        [Header("Config")]
        [SerializeField]
        private LoadSceneRequest _loadSceneRequest = default!;

        [Header("Broadcasting on")]
        [SerializeField]
        private LoadSceneRequestEvent _loadSceneEvent = default!;

        public override void Do()
        {
            base.Do();
            _loadSceneEvent.Raise(_loadSceneRequest);
        }

        public override void Do(GameSceneSO gameSceneSO)
        {
            base.Do(gameSceneSO);
            var request = _loadSceneRequest.With(gameSceneSO);
            _loadSceneEvent.Raise(request);
        }
    }
}