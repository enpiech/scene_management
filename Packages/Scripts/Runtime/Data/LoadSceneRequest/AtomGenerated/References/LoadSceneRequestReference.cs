using System;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Constants;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Functions;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Pairs;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.VariableInstancers;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Variables;
using UnityAtoms;

namespace Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.References
{
    /// <summary>
    ///     Reference of type `LoadSceneRequest`. Inherits from `AtomReference&lt;LoadSceneRequest, LoadSceneRequestPair,
    ///     LoadSceneRequestConstant, LoadSceneRequestVariable, LoadSceneRequestEvent, LoadSceneRequestPairEvent,
    ///     LoadSceneRequestLoadSceneRequestFunction, LoadSceneRequestVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LoadSceneRequestReference : AtomReference<
        LoadSceneRequest,
        LoadSceneRequestPair,
        LoadSceneRequestConstant,
        LoadSceneRequestVariable,
        LoadSceneRequestEvent,
        LoadSceneRequestPairEvent,
        LoadSceneRequestLoadSceneRequestFunction,
        LoadSceneRequestVariableInstancer>, IEquatable<LoadSceneRequestReference>
    {
        public LoadSceneRequestReference()
        {
        }

        public LoadSceneRequestReference(LoadSceneRequest value) : base(value)
        {
        }

        public bool Equals(LoadSceneRequestReference other)
        {
            return base.Equals(other);
        }

        protected override bool ValueEquals(LoadSceneRequest other)
        {
            throw new NotImplementedException();
        }
    }
}