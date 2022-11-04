using SceneManagement.Pairs;
using UnityAtoms;
using UnityEngine;

namespace SceneManagement.Events
{
    /// <summary>
    ///     Event of type `LoadSceneRequestPair`. Inherits from `AtomEvent&lt;LoadSceneRequestPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/LoadSceneRequestPair", fileName = "LoadSceneRequestPairEvent")]
    public sealed class LoadSceneRequestPairEvent : AtomEvent<LoadSceneRequestPair>
    {
    }
}