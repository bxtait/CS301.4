using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class LevelMove_Ref : MonoBehaviour
{
    public int sceneBuildIndex;
 
 
    // Move game to another scene
    private void OnTriggerEnter2D(Collider2D other) {
        print("Trigger Entered");
        

        if(other.tag == "Player") {
            // Player entered, so move level
            print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
