
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public AudioSource audio; // Reference to the audio source component

    // Method to play the click audio
    public void PlayClickAudio()
    {
        if (audio != null)
        {
            audio.Play();
                    // Exit Game
        Debug.Log("QUIT");
        Application.Quit();
        }


    }

 

}
