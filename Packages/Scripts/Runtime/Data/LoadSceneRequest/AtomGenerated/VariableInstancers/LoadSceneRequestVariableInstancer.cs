using SceneManagement.Events;
using SceneManagement.Functions;
using SceneManagement.Pairs;
using SceneManagement.Variables;
using UnityAtoms;
using UnityEngine;

namespace SceneManagement.VariableInstancers
{
    /// <summary>
    ///     Variable Instancer of type `LoadSceneRequest`. Inherits from `AtomVariableInstancer&lt;LoadSceneRequestVariable,
    ///     LoadSceneRequestPair, LoadSceneRequest, LoadSceneRequestEvent, LoadSceneRequestPairEvent,
    ///     LoadSceneRequestLoadSceneRequestFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/LoadSceneRequest Variable Instancer")]
    public class LoadSceneRequestVariableInstancer : AtomVariableInstancer<
        LoadSceneRequestVariable,
        LoadSceneRequestPair,
        LoadSceneRequest,
        LoadSceneRequestEvent,
        LoadSceneRequestPairEvent,
        LoadSceneRequestLoadSceneRequestFunction>
    {
    }
}