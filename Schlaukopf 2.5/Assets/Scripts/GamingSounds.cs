using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamingSounds : MonoBehaviour
{
    static GamingSounds instance;
 
    public AudioClip[] AudioClips;
    public AudioSource Sounds;

     // This function is needed to keep an instance alive over all scenes
     void Awake()
     {
         if (instance == null) 
         {
             instance = this; 
         }
         else 
         {
             Destroy(gameObject); 
         }
 
         DontDestroyOnLoad(gameObject);
 
         SceneManager.sceneLoaded += OnSceneLoaded;
     }
 
     // This function is called whenever a scene is loaded and decides which music is playing
     void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
     {
         //AudioSource source = new AudioSource();
 
         Scene activeScene = SceneManager.GetActiveScene();
         switch (activeScene.name)
         {
             case "Menu":
                 Debug.Log("Szene Menu is loaded");
                 Sounds.clip = AudioClips[0];
                 Sounds.enabled = false;
                 Sounds.enabled = true;
                 break;
             case "BaseScene":
                 Debug.Log("Szene BaseScene is loaded");
                 Sounds.clip = AudioClips[1];
                 Sounds.enabled = false;
                 Sounds.enabled = true;
                 break;
         }
     }
}
