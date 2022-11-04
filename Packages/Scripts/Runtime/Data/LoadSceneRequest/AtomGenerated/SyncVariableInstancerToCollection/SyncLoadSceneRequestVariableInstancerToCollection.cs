using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.VariableInstancers;
using Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.Variables;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Enpiech.SceneManagement.Runtime.Data.LoadSceneRequest.AtomGenerated.SyncVariableInstancerToCollection
{
    /// <summary>
    ///     Adds Variable Instancer's Variable of type LoadSceneRequest to a Collection or List on OnEnable and removes it on
    ///     OnDestroy.
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync LoadSceneRequest Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncLoadSceneRequestVariableInstancerToCollection : SyncVariableInstancerToCollection<LoadSceneRequest,
        LoadSceneRequestVariable, LoadSceneRequestVariableInstancer>
    {
    }
}