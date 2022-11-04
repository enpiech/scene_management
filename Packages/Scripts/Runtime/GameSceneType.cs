namespace Enpiech.SceneManagement.Runtime
{
    /// <summary>
    ///     Used by the SceneSelector tool to discern what type of scene it needs to load
    /// </summary>
    public enum GameSceneType
    {
        /// <summary>
        ///     Playable scenes
        ///     SceneSelector tool will also load PersistentManagers and Gameplay
        /// </summary>
        GameplayLevel,

        /// <summary>
        ///     SceneSelector tool will also load Gameplay
        /// </summary>
        Menu,

        //Special scenes
        Initialization,
        PersistentManagers,
        GameplayManager,

        /// <summary>
        ///     Work in progress scenes that don't need to be played
        /// </summary>
        Art
    }
}