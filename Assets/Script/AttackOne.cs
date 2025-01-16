using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackOne : MonoBehaviour, IStratergy
{
    [SerializeField] private int damage;

    public void Attack()
    {
        Debug.Log($"You attacked and caused {damage} damage. This is the first attack!");
    }
}
