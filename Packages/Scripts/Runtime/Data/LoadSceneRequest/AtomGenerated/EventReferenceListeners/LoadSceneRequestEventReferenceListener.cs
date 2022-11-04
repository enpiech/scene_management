using SceneManagement.EventReferences;
using SceneManagement.Events;
using SceneManagement.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace SceneManagement.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `LoadSceneRequest`. Inherits from `AtomEventReferenceListener&lt;LoadSceneRequest,
    ///     LoadSceneRequestEvent, LoadSceneRequestEventReference, LoadSceneRequestUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/LoadSceneRequest Event Reference Listener")]
    public sealed class LoadSceneRequestEventReferenceListener : AtomEventReferenceListener<
        LoadSceneRequest,
        LoadSceneRequestEvent,
        LoadSceneRequestEventReference,
        LoadSceneRequestUnityEvent>
    {
    }
}