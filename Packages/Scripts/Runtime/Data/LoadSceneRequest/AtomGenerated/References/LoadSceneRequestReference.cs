using System;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Constants;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Functions;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Pairs;
using Runtime.Data.LoadSceneRequest.AtomGenerated.VariableInstancers;
using Runtime.Data.LoadSceneRequest.AtomGenerated.Variables;
using UnityAtoms;

namespace Runtime.Data.LoadSceneRequest.AtomGenerated.References
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