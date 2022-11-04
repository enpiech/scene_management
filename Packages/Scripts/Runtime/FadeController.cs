using Core.UI.AtomGenerated.Events;
using Core.UI.Data;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Runtime
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