using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Constants;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Functions;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Pairs;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.References;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.VariableInstancers;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Variables;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Actions.SetVariableValue
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