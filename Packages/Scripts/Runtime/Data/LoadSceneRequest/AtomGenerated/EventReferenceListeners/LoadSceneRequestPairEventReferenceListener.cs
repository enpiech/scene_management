using SceneManagement.EventReferences;
using SceneManagement.Events;
using SceneManagement.Pairs;
using SceneManagement.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace SceneManagement.EventReferenceListeners
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