using System;
using Runtime.ScriptableObjects;
using UnityEngine;
using UnityEngine.Serialization;

namespace Runtime.Data.LoadSceneRequest
{
    [Serializable]
    public class LoadSceneRequest
    {
        [SerializeField]
        [Range(0, 1)]
        private float _loadingPercent;

        [SerializeField]
        [Range(0, 1)]
        private float _loadedPercent;

        [SerializeField]
        private GameSceneSO _sceneToLoad;

        [FormerlySerializedAs("_shouldShowLoadingScreen")]
        [SerializeField]
        private bool _shouldShowLoadingScreenOnLoading;

        [SerializeField]
        private bool _shouldHideLoadingScreenOnLoaded;

        [SerializeField]
        private bool _isFadeOnTransition;

        public LoadSceneRequest(GameSceneSO sceneToLoad, bool shouldShowLoadingScreenOnLoading = false, bool shouldHideLoadingScreenOnLoaded
            = false, bool isFadeOnTransition = false, float loadingPercent = 0, float loadedPercent = 1f)
        {
            _sceneToLoad = sceneToLoad;
            _shouldShowLoadingScreenOnLoading = shouldShowLoadingScreenOnLoading;
            _shouldHideLoadingScreenOnLoaded = shouldHideLoadingScreenOnLoaded;
            _isFadeOnTransition = isFadeOnTransition;
            _loadingPercent = loadingPercent;
            _loadedPercent = loadedPercent;
        }

        public bool ShouldHideLoadingScreenOnLoaded => _shouldHideLoadingScreenOnLoaded;

        public GameSceneSO SceneToLoad => _sceneToLoad;

        public bool ShouldShowLoadingScreenOnLoading => _shouldShowLoadingScreenOnLoading;

        public bool IsFadeOnTransition => _isFadeOnTransition;

        public float LoadingPercent => _loadingPercent;

        public float LoadedPercent => _loadedPercent;

        public LoadSceneRequest With(GameSceneSO sceneToLoad)
        {
            return new LoadSceneRequest(sceneToLoad, _shouldShowLoadingScreenOnLoading, _shouldHideLoadingScreenOnLoaded,
                _isFadeOnTransition, _loadingPercent, _loadedPercent);
        }
    }
}