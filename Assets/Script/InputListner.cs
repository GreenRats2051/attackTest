using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class InputListener : MonoBehaviour
    {
        private AttackContext _attackContext;
        private Dictionary<Button, IStratergy> _attackStrategies;
        private Button _currentAttackButton;
        private Animator animator;
        private KT_2.EnemyManager enemyManager;

        public void Initialize(KT_2.EnemyManager enemyManager)
        {
            this.enemyManager = enemyManager;

            _attackContext = new AttackContext();
            _attackStrategies = new Dictionary<Button, IStratergy>
        {
            { GameObject.Find("Button (Legacy)_01").GetComponent<Button>(), new AttackOne(10) },
            { GameObject.Find("Button (Legacy)_02").GetComponent<Button>(), new AttackTwo(20) },
            { GameObject.Find("Button (Legacy)_03").GetComponent<Button>(), new AttackThree(30) }
        };

            animator = GetComponent<Animator>();

            foreach (var button in _attackStrategies.Keys)
            {
                button.onClick.AddListener(() => SetCurrentAttack(button));
            }
        }

        private void SetCurrentAttack(Button button)
        {
            if (_currentAttackButton != null)
            {
                ColorBlock colors = _currentAttackButton.colors;
                colors.normalColor = Color.white;
                _currentAttackButton.colors = colors;
            }

            _currentAttackButton = button;
            _currentAttackButton.colors = GetHighlightedColorBlock();

            _attackContext.SetStrategy(_attackStrategies[button]);

            PlayAttackAnimation(button);
        }

        private void PlayAttackAnimation(Button button)
        {
            if (button.name == "Button (Legacy)_01")
            {
                enemyManager.ChangeEnemy();
                animator.SetTrigger("Attack_01");
            }
            else if (button.name == "Button (Legacy)_02")
            {
                enemyManager.ChangeEnemy();
                animator.SetTrigger("Attack_02");
            }
        }

        private ColorBlock GetHighlightedColorBlock()
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