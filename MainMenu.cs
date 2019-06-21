using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{
/// <summary>
/// metoda wykonuje zmine sceny 'menu' na scenu 'Game' po kliknieciu 'button play'.
/// </summary>
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    /// <summary>
    /// metoda wykonuje zamkniecie gry po kliknieciu 'button quit'.
    /// </summary>
    public void QuitGame()
    {

        Debug.Log("QUIT!");
        Application.Quit();
    }

}
