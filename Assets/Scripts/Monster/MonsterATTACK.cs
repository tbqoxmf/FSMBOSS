using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterATTACK : MonsterFSMState {

    public override void BeginState()
    {
        base.BeginState();
        _manager.CC.CKLook(_manager.PlayerCC.transform);
    }

    public override void EndState()
    {
        base.EndState();
    }

    private void Update()
    {
        if (Vector3.Distance(_manager.PlayerTransform.position, transform.position) >= _manager.Stat.AttackRange)
        {
            _manager.SetState(MonsterState.CHASE);
            return;
        }

    }

    public void AttackCheck()
    {
        Debug.Log("AttackCheck");

        CharacterStat targetStat =
            _manager.PlayerCC.GetComponent<CharacterStat>();

        CharacterStat.ProcessDamage(_manager.Stat, targetStat);
    }
}
