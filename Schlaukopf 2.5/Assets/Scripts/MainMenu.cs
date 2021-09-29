using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Loads the basescene of the game.
    public void PlayGame ()
    {
        SceneManager.LoadScene("BaseScene");
    }

    // Quit from the main menu
    public void QuitGame()
     {
         Debug.Log ("QUIT!");
         Application.Quit();
     }
}
