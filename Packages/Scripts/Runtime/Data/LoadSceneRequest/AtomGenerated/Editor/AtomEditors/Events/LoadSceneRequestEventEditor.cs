#if UNITY_2019_1_OR_NEWER
using Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace Runtime.Data.LoadSceneRequest.AtomGenerated.Editor.AtomEditors.Events
{
    /// <summary>
    ///     Event property drawer of type `LoadSceneRequest`. Inherits from `AtomEventEditor&lt;LoadSceneRequest,
    ///     LoadSceneRequestEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(LoadSceneRequestEvent))]
    public sealed class LoadSceneRequestEventEditor : AtomEventEditor<LoadSceneRequest, LoadSceneRequestEvent>
    {
    }
}
#endif