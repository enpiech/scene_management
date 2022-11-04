using SceneManagement.Events;
using SceneManagement.Pairs;
using UnityAtoms;
using UnityEngine;

namespace SceneManagement.EventInstancers
{
    /// <summary>
    ///     Event Instancer of type `LoadSceneRequestPair`. Inherits from `AtomEventInstancer&lt;LoadSceneRequestPair,
    ///     LoadSceneRequestPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/LoadSceneRequestPair Event Instancer")]
    public class LoadSceneRequestPairEventInstancer : AtomEventInstancer<LoadSceneRequestPair, LoadSceneRequestPairEvent>
    {
    }
}