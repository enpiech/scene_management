#if UNITY_2019_1_OR_NEWER
using Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Pairs;
using UnityAtoms.Editor;
using UnityEditor;

namespace Editor.LoadSceneRequest.AtomGenerated.AtomEditors.Events
{
    /// <summary>
    ///     Event property drawer of type `LoadSceneRequestPair`. Inherits from `AtomEventEditor&lt;LoadSceneRequestPair,
    ///     LoadSceneRequestPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(LoadSceneRequestPairEvent))]
    public sealed class LoadSceneRequestPairEventEditor : AtomEventEditor<LoadSceneRequestPair, LoadSceneRequestPairEvent>
    {
    }
}
#endif