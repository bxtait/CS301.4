using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionManager : MonoBehaviour
{
    [SerializeField]
    private Text interactInstructionText;

    [SerializeField]
    private Text journalInstructionText;

    private bool hasInteracted = false;
    private bool journalInstructionShown = false;

    void Start()
    {
        // Initially show the interact instruction
        interactInstructionText.gameObject.SetActive(true);
        journalInstructionText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            if (!hasInteracted)
            {
                interactInstructionText.gameObject.SetActive(false);
                hasInteracted = true;
            }
        }

        if (hasInteracted && !journalInstructionShown)
        {
            StartCoroutine(ShowJournalInstructionAfterDialogue());
        }

        if (journalInstructionShown && Input.GetKeyDown(KeyCode.J))
        {
            journalInstructionText.gameObject.SetActive(false);
        }
    }

    private IEnumerator ShowJournalInstructionAfterDialogue()
    {
        // Wait for the dialogue to finish
        yield return new WaitUntil(() => DialogueManager.Instance.DialogueFinished); 
        journalInstructionText.gameObject.SetActive(true);
        journalInstructionShown = true;
    }
}


