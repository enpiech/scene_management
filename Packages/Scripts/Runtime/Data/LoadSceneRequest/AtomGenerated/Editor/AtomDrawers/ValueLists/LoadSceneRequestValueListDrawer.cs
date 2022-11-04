#if UNITY_2019_1_OR_NEWER
using SceneManagement.ValueLists;
using UnityAtoms.Editor;
using UnityEditor;

namespace SceneManagement.Editor.AtomDrawers.ValueLists
{
    /// <summary>
    ///     Value List property drawer of type `LoadSceneRequest`. Inherits from `AtomDrawer&lt;LoadSceneRequestValueList&gt;`.
    ///     Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LoadSceneRequestValueList))]
    public class LoadSceneRequestValueListDrawer : AtomDrawer<LoadSceneRequestValueList>
    {
    }
}
#endif