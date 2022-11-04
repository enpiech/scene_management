using System;
using UnityEngine.Events;

namespace SceneManagement.UnityEvents
{
    /// <summary>
    ///     None generic Unity Event of type `LoadSceneRequest`. Inherits from `UnityEvent&lt;LoadSceneRequest&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LoadSceneRequestUnityEvent : UnityEvent<LoadSceneRequest>
    {
    }
}