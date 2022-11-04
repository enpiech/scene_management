using Runtime.Data.LoadSceneRequest.AtomGenerated.EventReferences;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Pairs;
using Runtime.Data.LoadSceneRequest.AtomGenerated.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Runtime.Data.LoadSceneRequest.AtomGenerated.EventReferenceListeners
{
    /// <summary>
    ///     Event Reference Listener of type `LoadSceneRequestPair`. Inherits from `AtomEventReferenceListener&lt;
    ///     LoadSceneRequestPair, LoadSceneRequestPairEvent, LoadSceneRequestPairEventReference, LoadSceneRequestPairUnityEvent
    ///     &gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/LoadSceneRequestPair Event Reference Listener")]
    public sealed class LoadSceneRequestPairEventReferenceListener : AtomEventReferenceListener<
        LoadSceneRequestPair,
        LoadSceneRequestPairEvent,
        LoadSceneRequestPairEventReference,
        LoadSceneRequestPairUnityEvent>
    {
    }
}