using System;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Events;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Functions;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Pairs;
using UnityAtoms;
using UnityEngine;

namespace Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Variables
{
    /// <summary>
    ///     Variable of type `LoadSceneRequest`. Inherits from `AtomVariable&lt;LoadSceneRequest, LoadSceneRequestPair,
    ///     LoadSceneRequestEvent, LoadSceneRequestPairEvent, LoadSceneRequestLoadSceneRequestFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/LoadSceneRequest", fileName = "LoadSceneRequestVariable")]
    public sealed class LoadSceneRequestVariable : AtomVariable<LoadSceneRequest, LoadSceneRequestPair, LoadSceneRequestEvent,
        LoadSceneRequestPairEvent, LoadSceneRequestLoadSceneRequestFunction>
    {
        protected override bool ValueEquals(LoadSceneRequest other)
        {
            throw new NotImplementedException();
        }
    }
}