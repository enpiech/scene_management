#if UNITY_2019_1_OR_NEWER
using Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace Runtime.Data.LoadSceneRequest.AtomGenerated.Editor.AtomDrawers.Events
{
    /// <summary>
    ///     Event property drawer of type `LoadSceneRequest`. Inherits from `AtomDrawer&lt;LoadSceneRequestEvent&gt;`. Only
    ///     availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LoadSceneRequestEvent))]
    public class LoadSceneRequestEventDrawer : AtomDrawer<LoadSceneRequestEvent>
    {
    }
}
#endif