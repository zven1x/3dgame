using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private AggroDetection aggroDetection;

    private Transform target;
   
    /// <summary>
    /// dodajemy do metody Awake pola ktore bedzie wlaczac animacje i uruchomienie persony.
    /// metoda wykouje sie przy podejsciu glownej persony do enemy.
    /// </summary>
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        aggroDetection = GetComponent<AggroDetection>();
        aggroDetection.OnAggro += AggroDetection_OnAggro;
   
     }
    /// <summary>
    /// metoda wywoluje sie przy podejsciu glownej persony do enemy.
    /// metowa wykonuje przesylanie zmiennej target jaka Action.
    /// </summary>
    /// <param name="target"></param>
    private void AggroDetection_OnAggro(Transform target)
    {
        this.target = target;
    }
    /// <summary>
    /// dodajmy do metody Update pola ktore tworzy dystancje do glownej persony od enemy .
    /// </summary>
    private void Update()
    {
        if (target != null)
        {
            navMeshAgent.SetDestination(target.position);
            float currentspeed = navMeshAgent.velocity.magnitude;
            animator.SetFloat("Speed", currentspeed);
        }
    }
}