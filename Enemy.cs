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
    /// <summary>
    /// Dodajemy do metody Awake pobieranie componentow z klassy AggroDetection.
    /// </summary>
    private void Awake()
    {
        aggroDetection = GetComponent<AggroDetection>();
        aggroDetection.OnAggro += AggroDetection_OnAggro;
    }
    /// <summary>
    /// Metoda wykonuje polaczenie klassy Enemy z klasa health zadla otrzymania pozamu zdrowia.
    /// </summary>
    /// <param name="target"></param>
    private void AggroDetection_OnAggro(Transform target)
    {

        Health health = target.GetComponent<Health>();
        if (health != null)
        {
            healthTarget = health;
        }
    }
    /// <summary>
    /// Dodajemy do metody Update pola ktore w przypadku pozytywnego poziomu zdrowia u Aktora(Player) wykonuje metode Attack.
    /// </summary>
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
    /// <summary>
    /// Metoda CanAttack ktora zastanawia czesliwosc i rozmiar ataku.
    /// </summary>
    /// <returns></returns>
    private bool CanAttack()
    {
        return attackTimer >= attackRefreshRate;
    }
    /// <summary>
    /// Metoda ktora wykonuje zamiscienie Aktora(Player) w neaktywny stan przy smierci .
    /// </summary>
    private void Attack()
    {
        throw new NotImplementedException();
    }
}
