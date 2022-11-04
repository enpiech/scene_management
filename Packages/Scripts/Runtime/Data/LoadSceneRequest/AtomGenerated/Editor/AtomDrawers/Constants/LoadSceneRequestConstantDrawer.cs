#if UNITY_2019_1_OR_NEWER
using SceneManagement.Constants;
using UnityAtoms.Editor;
using UnityEditor;

namespace SceneManagement.Editor.AtomDrawers.Constants
{
    /// <summary>
    ///     Constant property drawer of type `LoadSceneRequest`. Inherits from `AtomDrawer&lt;LoadSceneRequestConstant&gt;`.
    ///     Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LoadSceneRequestConstant))]
    public class LoadSceneRequestConstantDrawer : VariableDrawer<LoadSceneRequestConstant>
    {
    }
}
#endif