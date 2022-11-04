using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Pairs;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Variables;
using UnityAtoms.Editor;
using UnityEditor;

namespace Enpiech.SceneManagement.Editor.LoadSceneRequest.AtomGenerated.AtomEditors.Variables
{
    /// <summary>
    ///     Variable Inspector of type `LoadSceneRequest`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(LoadSceneRequestVariable))]
    public sealed class
        LoadSceneRequestVariableEditor : AtomVariableEditor<Runtime.Data.LoadSceneRequest.LoadSceneRequest, LoadSceneRequestPair>
    {
    }
}