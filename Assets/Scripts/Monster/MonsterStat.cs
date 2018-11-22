using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStat : CharacterStat
{
    public StatData stateData;

    private void Awake()
    {
        Hp = stateData.monsterMaxHP;
        AttackRange = stateData.monsterAttackRange;
        MoveSpeed = stateData.monsterMoveSpeed;
        TurnSpeed = stateData.monsterTurnSpeede;
    }
}
