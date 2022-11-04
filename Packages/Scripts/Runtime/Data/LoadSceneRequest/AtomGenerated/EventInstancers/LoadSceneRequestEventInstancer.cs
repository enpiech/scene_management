using SceneManagement.Events;
using UnityAtoms;
using UnityEngine;

namespace SceneManagement.EventInstancers
{
    /// <summary>
    ///     Event Instancer of type `LoadSceneRequest`. Inherits from `AtomEventInstancer&lt;LoadSceneRequest,
    ///     LoadSceneRequestEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/LoadSceneRequest Event Instancer")]
    public class LoadSceneRequestEventInstancer : AtomEventInstancer<LoadSceneRequest, LoadSceneRequestEvent>
    {
    }
}