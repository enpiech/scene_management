using Runtime.Data.LoadSceneRequest.AtomGenerated.EventReferences;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Runtime.Data.LoadSceneRequest.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Runtime.Data.LoadSceneRequest.AtomGenerated.EventReferenceListeners
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