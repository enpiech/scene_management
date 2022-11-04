using System;
using SceneManagement.Pairs;
using UnityEngine.Events;

namespace SceneManagement.UnityEvents
{
    /// <summary>
    ///     None generic Unity Event of type `LoadSceneRequestPair`. Inherits from `UnityEvent&lt;LoadSceneRequestPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LoadSceneRequestPairUnityEvent : UnityEvent<LoadSceneRequestPair>
    {
    }
}