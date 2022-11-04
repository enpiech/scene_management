using System;
using SceneManagement.EventInstancers;
using SceneManagement.Events;
using SceneManagement.Pairs;
using SceneManagement.VariableInstancers;
using SceneManagement.Variables;
using UnityAtoms;

namespace SceneManagement.EventReferences
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