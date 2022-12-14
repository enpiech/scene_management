using DG.Tweening;
using Enpiech.Core.Runtime.UI.Data;
using Enpiech.Core.Runtime.UI.Fade.AtomGenerated.Events;
using UnityEngine;
using UnityEngine.UI;

namespace Enpiech.SceneManagement.Runtime
{
    public sealed class FadeController : MonoBehaviour
    {
        [Header("References")]
        [SerializeField]
        private Image _imageComponent = null!;

        [Header("Listening to")]
        [SerializeField]
        private FadeEvent _fadeEventChannel = null!;

        private void OnEnable()
        {
            _fadeEventChannel.Register(OnFade);
        }

        private void OnDisable()
        {
            _fadeEventChannel.Unregister(OnFade);
        }

        /// <summary>
        ///     Controls the fade-in and fade-out.
        /// </summary>
        private void OnFade(Fade fadeSetting)
        {
            _imageComponent.DOBlendableColor(fadeSetting.Color, fadeSetting.Duration);
        }
    }
}