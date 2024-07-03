using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalController : MonoBehaviour
{
    [SerializeField]
    private UIJournalPage journalUI;

    public int journalSize = 10;

    private void Start()
    {
        journalUI.InitializeJournalUI(journalSize);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (!journalUI.isActiveAndEnabled)
            {
                journalUI.Show();
            }
            else
            {
                journalUI.Hide();
            }
        }
    }
}
