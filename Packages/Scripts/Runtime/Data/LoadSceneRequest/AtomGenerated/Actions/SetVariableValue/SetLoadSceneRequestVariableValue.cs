using Runtime.Data.LoadSceneRequest.AtomGenerated.Constants;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Functions;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Pairs;
using Runtime.Data.LoadSceneRequest.AtomGenerated.References;
using Runtime.Data.LoadSceneRequest.AtomGenerated.VariableInstancers;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Runtime.Data.LoadSceneRequest.AtomGenerated.Actions.SetVariableValue
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