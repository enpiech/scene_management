#if UNITY_2019_1_OR_NEWER
using SceneManagement.Variables;
using UnityAtoms.Editor;
using UnityEditor;

namespace SceneManagement.Editor.AtomDrawers.Variables
{
    /// <summary>
    ///     Variable property drawer of type `LoadSceneRequest`. Inherits from `AtomDrawer&lt;LoadSceneRequestVariable&gt;`.
    ///     Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LoadSceneRequestVariable))]
    public class LoadSceneRequestVariableDrawer : VariableDrawer<LoadSceneRequestVariable>
    {
    }
}
#endif