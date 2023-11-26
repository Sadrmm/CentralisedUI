using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ProgramadorCastellano.CentralisedUI
{
    [RequireComponent(typeof(Selectable))]
    public class CentralisedUIData : MonoBehaviour
    {
        [SerializeField] Selectable.Transition _transitionMode = Selectable.Transition.ColorTint;

        [Header("Color Tint")]
        [SerializeField] CentralisedUIColorTintSO _colorTintSO = default;
        [Header("Sprite Swap")]
        [SerializeField] CentralisedUISpriteSwapSO _spriteSwapSO = default;
        [Header("Animation")]
        [SerializeField] CentralisedUIAnimationSO _animationSO = default;

        private Selectable _selectable;
        private Dictionary<Selectable.Transition, UnityAction> _transitionActions;

        private void Awake()
        {
            Initialize();

            OnSkinUI();
        }

        private void Initialize()
        {
            _selectable = GetComponent<Selectable>();

            _transitionActions = new Dictionary<Selectable.Transition, UnityAction>()
            {
                { Selectable.Transition.ColorTint, () => _selectable.colors = _colorTintSO.Colors },
                { Selectable.Transition.SpriteSwap, () => _selectable.spriteState = _spriteSwapSO.Sprites },
                { Selectable.Transition.Animation, () => _selectable.animationTriggers = _animationSO.Animations }
            };
        }

        public void OnSkinUI()
        {
#if UNITY_EDITOR
            // only happens when it is invoked from the editor
            if (_selectable == null || _transitionActions == null) {
                Initialize();
            }
#endif
            _selectable.transition = _transitionMode;
            if (!_transitionActions.ContainsKey(_transitionMode)) {
                Debug.LogWarning($"Transition mode '{_transitionMode}' not implemented");
            }
            else {
                _transitionActions[_transitionMode]?.Invoke();
            }
        }
    }
}
