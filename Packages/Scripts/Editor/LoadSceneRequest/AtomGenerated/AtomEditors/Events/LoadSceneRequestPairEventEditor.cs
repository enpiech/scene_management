#if UNITY_2019_1_OR_NEWER
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Pairs;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.SceneManagement.Editor.LoadSceneRequest.AtomGenerated.AtomEditors.Events
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