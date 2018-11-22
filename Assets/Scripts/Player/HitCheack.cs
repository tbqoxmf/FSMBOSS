using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCheack : MonoBehaviour
{

    FSMManager _manager;

    private void Awake()
    {
        _manager = transform.root.GetComponent<FSMManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Monster")
        {
            PlayerATTACK attackState = _manager.CurrentStateComponent as PlayerATTACK;
            if (null != attackState)
            {
                attackState.AttackCheck();
            }
        }
    }
}
