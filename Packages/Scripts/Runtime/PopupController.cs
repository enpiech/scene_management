using Enpiech.Core.Runtime.UI.Popup;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Runtime
{
    public sealed class PopupController : MonoBehaviour
    {
        [SerializeField]
        private UIPopup _popupUI = default!;

        [SerializeField]
        private GameObjectVariable _popupUIReference = default!;

        private void OnEnable()
        {
            _popupUIReference.Value = _popupUI.gameObject;
        }
    }
}