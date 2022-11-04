using System;
using SceneManagement.EventInstancers;
using SceneManagement.Events;
using SceneManagement.VariableInstancers;
using SceneManagement.Variables;
using UnityAtoms;

namespace SceneManagement.EventReferences
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