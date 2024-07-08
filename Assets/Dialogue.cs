/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    // UI references
    [SerializeField]
    private GameObject dialogueCanvas;

    [SerializeField]
    private TMP_Text speakerText;

    [SerializeField]
    private TMP_Text dialogueText;

    [SerializeField]
    private Image portraitImage;

    // Dialogue Content
    [SerializeField]
    private string[] speaker;

    [SerializeField]
    [TextArea]
    private string[] dialogueWords;


    private bool dialogueActivated;
    private int step;

    void Start()
    {
        dialogueCanvas.SetActive(false); // Ensure canvas starts inactive
        step = 0; // Initialize step counter
    }

    void Update()
    {
        if (Input.GetButtonDown("Interact") && dialogueActivated)
        {
            if (step >= speaker.Length)
            {
                dialogueCanvas.SetActive(false);
                step = 0; // Reset step counter
                return; // Exit Update() early
            }

            dialogueCanvas.SetActive(true);
            speakerText.text = speaker[step];
            dialogueText.text = dialogueWords[step];


            step += 1; // Increment step counter
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueActivated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueActivated = false;
            dialogueCanvas.SetActive(false);
            step = 0; // Reset step counter when player exits trigger
        }
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    // UI references
    [SerializeField]
    private GameObject dialogueCanvas;

    [SerializeField]
    private TMP_Text speakerText;

    [SerializeField]
    private TMP_Text dialogueText;

    // Dialogue Content
    [SerializeField]
    private string[] speaker;

    [SerializeField]
    [TextArea]
    private string[] dialogueWords;

    private bool dialogueActivated;
    private int step;

    void Start()
    {
        dialogueCanvas.SetActive(false); // Ensure canvas starts inactive
        step = 0; // Initialize step counter
    }

    void Update()
    {
        if (Input.GetButtonDown("Interact") && dialogueActivated)
        {
            if (step >= speaker.Length)
            {
                dialogueCanvas.SetActive(false);
                step = 0; // Reset step counter
                DialogueManager.Instance.FinishDialogue(); // Notify that dialogue is finished
                return; // Exit Update() early
            }

            dialogueCanvas.SetActive(true);
            speakerText.text = speaker[step];
            dialogueText.text = dialogueWords[step];
            step += 1; // Increment step counter
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueActivated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueActivated = false;
            dialogueCanvas.SetActive(false);
            step = 0; // Reset step counter when player exits trigger
        }
    }
}
