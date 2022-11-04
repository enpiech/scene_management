using SceneManagement.Pairs;
using SceneManagement.Variables;
using UnityAtoms.Editor;
using UnityEditor;

namespace SceneManagement.Editor.AtomEditors.Variables
{
    /// <summary>
    ///     Variable Inspector of type `LoadSceneRequest`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(LoadSceneRequestVariable))]
    public sealed class LoadSceneRequestVariableEditor : AtomVariableEditor<LoadSceneRequest, LoadSceneRequestPair>
    {
    }
}