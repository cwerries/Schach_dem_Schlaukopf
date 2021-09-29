using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MusicControl : MonoBehaviour
{
    
    public void changeLabel(){
        GameObject LabelOn = GameObject.Find("/Canvas/OptionsMenu/MusicOnOff/LabelOn");
        GameObject LabelOff = GameObject.Find("/Canvas/OptionsMenu/MusicOnOff/LabelOff");
        AudioListener AudioListener = GameObject.FindObjectOfType<AudioListener>();;

        // Toggle is deselected (checkmarked is not present), Label is turned in "music off" and audio listerner is turned off
        if(LabelOn.activeInHierarchy){
            LabelOn.SetActive(false);
            LabelOff.SetActive(true);
            AudioListener.volume = 0;

        }
        // Toggle is selected (checkmarked is present), Label is turned in "music on" and audio listerner is turned on
        else{
            LabelOn.SetActive(true);
            LabelOff.SetActive(false);
            AudioListener.volume = 1;
        }
        
    }
}
