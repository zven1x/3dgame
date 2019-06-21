using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AggroDetection : MonoBehaviour
{
    public event Action<Transform> OnAggro = delegate { };
    /// <summary>
    /// metoda jest stworzona dla intydefikacji glownej Aktor(player).
    /// dla tego tworzy kapsule ktora powoduje ("Aggro") jezeli Aktor(player) wchodzi w Sphera collider, co powoduje atake.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerMovements>();
        if(player!=null)
        {
            OnAggro(player.transform);
            Debug.Log("Aggrod");
           
        }

    }

}
