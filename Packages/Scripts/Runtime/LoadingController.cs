using Enpiech.Core.Runtime.UI;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Runtime
{
    public sealed class LoadingController : MonoBehaviour
    {
        [Header("References")]
        [SerializeField]
        private LoadingBar _loadingBar = default!;

        [Header("Listening to")]
        [SerializeField]
        private BoolEvent _toggleLoadingEvent = default!;

        private void OnEnable()
        {
            _toggleLoadingEvent.Register(OnToggleLoadingEvent);
        }

        private void OnDisable()
        {
            _toggleLoadingEvent.Unregister(OnToggleLoadingEvent);
        }

        private void OnToggleLoadingEvent(bool isEnable)
        {
            _loadingBar.gameObject.SetActive(isEnable);
        }
    }
}