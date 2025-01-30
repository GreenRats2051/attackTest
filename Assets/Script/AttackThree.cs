using UnityEngine;

namespace Scripts
{
    public class AttackThree : IStratergy
    {
        private int damage;

        public AttackThree(int damage)
        {
            this.damage = damage;
        }

        public void Attack()
        {
            Debug.Log($"You attacked and caused {damage} damage. This is the third attack!");
        }
    }
}
