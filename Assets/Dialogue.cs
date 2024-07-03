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

    [SerializeField]
    private Image portraitImage;

    // Dialogue Content
    [SerializeField]
    private string[] speaker;

    [SerializeField]
    [TextArea]
    private string[] dialogueWords;

    [SerializeField]
    private Sprite[] portrait;

    private bool dialogueActivated;
    private int step;

    void Start()
    {
        // Ensure the dialogue canvas is not visible at the start
        dialogueCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Interact") && dialogueActivated)
        {
            if(step >= speaker.Length)
            {
                dialogueCanvas.SetActive(false);
                step = 0;
            }
            else
            {

            dialogueCanvas.SetActive(true);
            speakerText.text = speaker[0];
            dialogueText.text = dialogueWords[0];
            portraitImage.sprite = portrait[0];
            step +=1;
            
            }


            dialogueCanvas.SetActive(true);
            speakerText.text = speaker[0];
            dialogueText.text = dialogueWords[0];
            portraitImage.sprite = portrait[0];
            step +=1;
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
        }
    }
}
