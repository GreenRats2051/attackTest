using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class AttackPerformer : MonoBehaviour
    {
        private Button _currentAttackButton;
        private Animator animator;

        public void SetCurrentAttack(Button button)
        {
            if (_currentAttackButton != null)
            {
                ColorBlock colors = _currentAttackButton.colors;
                colors.normalColor = Color.white;
                _currentAttackButton.colors = colors;
            }

            _currentAttackButton = button;
            _currentAttackButton.colors = GetHighlightedColorBlock();

            PlayAttackAnimation(button);
        }

        public void PlayAttackAnimation(Button button)
        {
            if (button.name == "Button (Legacy)_01")
            {
                animator.SetTrigger("Attack_01");
            }
            else if (button.name == "Button (Legacy)_02")
            {
                animator.SetTrigger("Attack_02");
            }
        }

        public ColorBlock GetHighlightedColorBlock()
        {
            ColorBlock colors = new ColorBlock
            {
                normalColor = Color.white,
                highlightedColor = Color.yellow,
                pressedColor = Color.gray,
                disabledColor = Color.black,
                selectedColor = Color.yellow,
                colorMultiplier = 1,
                fadeDuration = 0.1f
            };
            return colors;
        }
    }
}