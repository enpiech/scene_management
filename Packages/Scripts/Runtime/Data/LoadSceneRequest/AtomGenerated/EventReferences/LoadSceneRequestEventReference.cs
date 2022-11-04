using System;
using Runtime.Data.LoadSceneRequest.AtomGenerated.EventInstancers;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Runtime.Data.LoadSceneRequest.AtomGenerated.VariableInstancers;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Variables;
using UnityAtoms;

namespace Runtime.Data.LoadSceneRequest.AtomGenerated.EventReferences
{
    /// <summary>
    ///     Event Reference of type `LoadSceneRequest`. Inherits from `AtomEventReference&lt;LoadSceneRequest,
    ///     LoadSceneRequestVariable, LoadSceneRequestEvent, LoadSceneRequestVariableInstancer, LoadSceneRequestEventInstancer
    ///     &gt;`.
    /// </summary>
    [Serializable]
    public sealed class LoadSceneRequestEventReference : AtomEventReference<
        LoadSceneRequest,
        LoadSceneRequestVariable,
        LoadSceneRequestEvent,
        LoadSceneRequestVariableInstancer,
        LoadSceneRequestEventInstancer>, IGetEvent
    {
    }
}