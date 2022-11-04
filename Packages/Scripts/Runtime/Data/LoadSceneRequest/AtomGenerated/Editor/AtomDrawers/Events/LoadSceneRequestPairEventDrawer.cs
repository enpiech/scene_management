#if UNITY_2019_1_OR_NEWER
using SceneManagement.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace SceneManagement.Editor.AtomDrawers.Events
{
    /// <summary>
    ///     Event property drawer of type `LoadSceneRequestPair`. Inherits from `AtomDrawer&lt;LoadSceneRequestPairEvent&gt;`.
    ///     Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LoadSceneRequestPairEvent))]
    public class LoadSceneRequestPairEventDrawer : AtomDrawer<LoadSceneRequestPairEvent>
    {
    }
}
#endif