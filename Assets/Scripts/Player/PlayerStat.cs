using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : CharacterStat
{
    public StatData stateData;

    private void Awake()
    {
        Hp = stateData.playerMaxHP;
        AttackRange = stateData.playerAttackRange;
        MoveSpeed = stateData.playerMoveSpeed;
        TurnSpeed = stateData.playerTurnSpeede;
    }

}
