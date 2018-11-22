﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStat : MonoBehaviour
{
    [SerializeField]
    private float _hp = 100.0f;
    public float Hp { get { return _hp; } set { _hp = value; } }

    [SerializeField]
    private float _moveSpeed = 3.0f;
    public float MoveSpeed { get { return _moveSpeed; } protected set { _moveSpeed = value; } }

    [SerializeField]
    private float _turnSpeed = 540.0f;
    public float TurnSpeed { get { return _turnSpeed; } protected set { _turnSpeed = value; } }

    [SerializeField]
    private float _attackRange = 2.0f;
    public float AttackRange { get { return _attackRange; } protected set { _attackRange = value; } }

    public CharacterStat lastHitBy = null;

    public void TakeDamage(CharacterStat from, float damage)
    {
        _hp = Mathf.Clamp(_hp - damage, 0, 100);
        if(_hp <= 0)
        {
            if (lastHitBy == null)
                lastHitBy = from;

            GetComponent<IFSMManager>().SetDeadState();
            from.GetComponent<IFSMManager>().NotifyTargetKilled();
            Debug.Log(name + " is Killed by " + lastHitBy.name);
        }
    }

    private static float CalcDamage(CharacterStat from, CharacterStat to)
    {
        return 1.0f;
    }

    public static void ProcessDamage(CharacterStat from, CharacterStat to)
    {
        float finalDamage = CalcDamage(from, to);
        to.TakeDamage(from, finalDamage);
    }
}
