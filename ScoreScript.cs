using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue = 0;
    internal static string text;
    Text score;

    /// <summary>
    /// Metoda wykonuje pobieranie terazniejszego poziomu Score.
    /// ktora wyswietla go w score.text.
    /// </summary>
    private void Start()
    {
        score = GetComponent<Text>();
    }


    /// <summary>
    /// dodajemy do metody Update funkcje ktora wykonuje dodawanie terazniejszego poziomu score do tego ktory otrzymuje z gry w scoreValue.
    /// </summary>
    void Update()
    {
        score.text = "Score:" + scoreValue;
        
    }

}
