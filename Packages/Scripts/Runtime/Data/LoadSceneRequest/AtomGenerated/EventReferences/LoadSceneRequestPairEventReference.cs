using System;
using Runtime.Data.LoadSceneRequest.AtomGenerated.EventInstancers;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Pairs;
using Runtime.Data.LoadSceneRequest.AtomGenerated.VariableInstancers;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Variables;
using UnityAtoms;

namespace Runtime.Data.LoadSceneRequest.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `LoadSceneRequestPair`. Inherits from `AtomEventReference&lt;LoadSceneRequestPair,
    ///     LoadSceneRequestVariable, LoadSceneRequestPairEvent, LoadSceneRequestVariableInstancer,
    ///     LoadSceneRequestPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LoadSceneRequestPairEventReference : AtomEventReference<
        LoadSceneRequestPair,
        LoadSceneRequestVariable,
        LoadSceneRequestPairEvent,
        LoadSceneRequestVariableInstancer,
        LoadSceneRequestPairEventInstancer>, IGetEvent
    {
    }
}