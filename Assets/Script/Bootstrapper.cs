using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class Bootstrapper : MonoBehaviour
    {
        private Dictionary<Button, IStratergy> _attackStrategies;
        private Button _currentAttackButton;
        private Animator animator;

        public void Initialize()
        {
            AttackPerformer attackPerformer = FindAnyObjectByType<AttackPerformer>();
            _attackStrategies = new Dictionary<Button, IStratergy>
        {
            { GameObject.Find("Button (Legacy)_01").GetComponent<Button>(), new AttackOne(10) },
            { GameObject.Find("Button (Legacy)_02").GetComponent<Button>(), new AttackTwo(20) },
            { GameObject.Find("Button (Legacy)_03").GetComponent<Button>(), new AttackThree(30) }
        };

            animator = GetComponent<Animator>();

            foreach (var button in _attackStrategies.Keys)
            {
                button.onClick.AddListener(() => AttackPerformer.SetCurrentAttack(button));
            }
        }
    }
}