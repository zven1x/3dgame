using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ 
    private AggroDetection aggroDetection;
    private Health healthTarget;
    private float attackRefreshRate = 1;
    private int attackTimer;

    private void Awake()
    {
        aggroDetection = GetComponent<AggroDetection>();
        aggroDetection.OnAggro += AggroDetection_OnAggro;
    }
    private void AggroDetection_OnAggro(Transform target)
    {

        Health health = target.GetComponent<Health>();
        if (health != null)
        {
            healthTarget = health;
        }
    }
    private void Update()
    {
        if (healthTarget !=null)
        {
            if (CanAttack())
            {
                Attack();
            }
        }
    }

    private bool CanAttack()
    {
        return attackTimer >= attackRefreshRate;
    }

    private void Attack()
    {
        throw new NotImplementedException();
    }
}
