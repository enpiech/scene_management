using SceneManagement.Events;
using UnityAtoms;
using UnityEngine;

namespace SceneManagement.ValueLists
{
    /// <summary>
    ///     Value List of type `LoadSceneRequest`. Inherits from `AtomValueList&lt;LoadSceneRequest, LoadSceneRequestEvent&gt;
    ///     `.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/LoadSceneRequest", fileName = "LoadSceneRequestValueList")]
    public sealed class LoadSceneRequestValueList : AtomValueList<LoadSceneRequest, LoadSceneRequestEvent>
    {
    }
}