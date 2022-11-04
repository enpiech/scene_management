#if UNITY_2019_1_OR_NEWER
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.SceneManagement.Editor.LoadSceneRequest.AtomGenerated.AtomDrawers.Events
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