using Core;
using Enpiech.Audio.Runtime.Data;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Runtime.ScriptableObjects
{
    /// <summary>
    ///     This class is a base class which contains what is common to all game scenes
    /// </summary>
    [CreateAssetMenu(menuName = "Scene Data/Scene")]
    public class GameSceneSO : DescriptionBaseSO
    {
        [SerializeField]
        private GameSceneType _sceneType;

        [SerializeField]
        [Tooltip("Used at runtime to load the scene from the right AssetBundle")]
        private AssetReference _sceneReference = default!;

        [SerializeField]
        private AudioCueSO? _musicTrack;

        public AssetReference SceneReference => _sceneReference;

        public GameSceneType SceneType => _sceneType;

        public AudioCueSO? MusicTrack => _musicTrack;
    }
}