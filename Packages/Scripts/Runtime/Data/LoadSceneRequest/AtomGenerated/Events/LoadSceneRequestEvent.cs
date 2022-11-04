using UnityAtoms;
using UnityEngine;

namespace SceneManagement.Events
{
    /// <summary>
    ///     Event of type `LoadSceneRequest`. Inherits from `AtomEvent&lt;LoadSceneRequest&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/LoadSceneRequest", fileName = "LoadSceneRequestEvent")]
    public sealed class LoadSceneRequestEvent : AtomEvent<LoadSceneRequest>
    {
    }
}