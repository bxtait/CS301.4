/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public float delay = 1.0f; // Adjust this to the length of your audio clip
    private MainMenuScript mainMenuScript; // Reference to the MainMenuScript

    void Start()
    {
        // Find and reference the MainMenuScript
        mainMenuScript = FindObjectOfType<MainMenuScript>();
    }

    public void LoadScene(string sceneName)
    {
        // Start the coroutine to handle the delay
        StartCoroutine(LoadSceneWithDelay(sceneName));
    }

    private IEnumerator LoadSceneWithDelay(string sceneName)
    {
        // Play the click audio if mainMenuScript is found
        if (mainMenuScript != null)
        {
            mainMenuScript.PlayClickAudio();
        }

        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Load the next scene
        SceneManager.LoadScene(sceneName);
    }
}
