using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour

{

    [SerializeField]
    // tworzenie zmiennej dla parametra zdrowia.
    private int startingHealth = 5;


    // tworzenie zmiennej dla obecnego parametru zdrowia.
    private int currentHealth;


    /// <summary>
    /// meoda jest stworzona dla przenoszenia zdrowia startowego do zdrowia obecngo.
    /// </summary>
    private void OnEnable()

    {

        currentHealth = startingHealth;

    }


    /// <summary>
    /// metoda jest tworzona dla spowodowania i pobierania szkody.
    /// w przypadku kiedy obecne zdrowie jest mniejsze lub rowne od 0 wywoluje sie metoda Die.
    /// </summary>
    /// <param name="damageAmount"></param>
    public void TakeDamage(int damageAmount)

    {

        currentHealth -= damageAmount;



        if (currentHealth <= 0)

            Die();

    }


    /// <summary>
    /// metoda jest wywolana w TakeDamage w tym przypadku kiedy poziom zdrowia jest mniejszy lub rowny 0 
    /// wykonuje SetActiwe(false) czyli deaktywuje object.
    /// </summary>
    private void Die()

    {

        gameObject.SetActive(false);

    }

}