using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseSceneButtons : MonoBehaviour
{
    // Quit from the Base Scene inside game
    public void QuitGame()
     {
         Debug.Log ("QUIT!");
         Application.Quit();
     }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}