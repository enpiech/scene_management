using System;
using SceneManagement.Constants;
using SceneManagement.Events;
using SceneManagement.Functions;
using SceneManagement.Pairs;
using SceneManagement.VariableInstancers;
using SceneManagement.Variables;
using UnityAtoms;

namespace SceneManagement.References
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