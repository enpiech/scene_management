using System;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Pairs
{
    /// <summary>
    ///     IPair of type `&lt;LoadSceneRequest&gt;`. Inherits from `IPair&lt;LoadSceneRequest&gt;`.
    /// </summary>
    [Serializable]
    public struct LoadSceneRequestPair : IPair<LoadSceneRequest>
    {
        [SerializeField]
        private LoadSceneRequest _item1;

        [SerializeField]
        private LoadSceneRequest _item2;

        public LoadSceneRequest Item1
        {
            get => _item1;
            set => _item1 = value;
        }

        public LoadSceneRequest Item2
        {
            get => _item2;
            set => _item2 = value;
        }

        public void Deconstruct(out LoadSceneRequest item1, out LoadSceneRequest item2)
        {
            item1 = Item1;
            item2 = Item2;
        }
    }
}