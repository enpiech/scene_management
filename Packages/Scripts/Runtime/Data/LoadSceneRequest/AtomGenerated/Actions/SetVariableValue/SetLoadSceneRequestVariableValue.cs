using SceneManagement.Constants;
using SceneManagement.Events;
using SceneManagement.Functions;
using SceneManagement.Pairs;
using SceneManagement.References;
using SceneManagement.VariableInstancers;
using SceneManagement.Variables;
using UnityAtoms;
using UnityEngine;

namespace SceneManagement.Actions.SetVariableValue
{
    /// <summary>
    ///     Set variable value Action of type `LoadSceneRequest`. Inherits from `SetVariableValue&lt;LoadSceneRequest,
    ///     LoadSceneRequestPair, LoadSceneRequestVariable, LoadSceneRequestConstant, LoadSceneRequestReference,
    ///     LoadSceneRequestEvent, LoadSceneRequestPairEvent, LoadSceneRequestVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/LoadSceneRequest", fileName = "SetLoadSceneRequestVariableValue")]
    public sealed class SetLoadSceneRequestVariableValue : SetVariableValue<
        LoadSceneRequest,
        LoadSceneRequestPair,
        LoadSceneRequestVariable,
        LoadSceneRequestConstant,
        LoadSceneRequestReference,
        LoadSceneRequestEvent,
        LoadSceneRequestPairEvent,
        LoadSceneRequestLoadSceneRequestFunction,
        LoadSceneRequestVariableInstancer>
    {
    }
}