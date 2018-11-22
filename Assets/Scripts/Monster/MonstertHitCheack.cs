using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstertHitCheack : MonoBehaviour {

    MonsterFSMManager _manager;


    private void Awake()
    {
        _manager = transform.root.GetComponent<MonsterFSMManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Player")
        {
            MonsterATTACK attackState = _manager.CurrentStateComponent as MonsterATTACK;
            if (null != attackState)
            {
                attackState.AttackCheck();
                GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
}
