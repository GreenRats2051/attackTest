using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    [field: SerializeField] private List<IStratergy> attacks;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            int index = Random.Range(0, attacks.Count);
            attacks[index].Attack();
        }
    }
}
