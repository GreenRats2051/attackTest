using UnityEngine;

namespace Scripts
{
    public class AttackTwo : IStratergy
    {
        private int damage;

        public AttackTwo(int damage)
        {
            this.damage = damage;
        }

        public void Attack()
        {
            Debug.Log($"You attacked and caused {damage} damage. This is the second attack!");
        }
    }
}
