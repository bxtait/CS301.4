using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Add this line to include the UnityEngine.UI namespace

public class QuestBookButtonBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject questPage;
    [SerializeField] private Text questTextBox; // Ensure Text is recognized from UnityEngine.UI
    [SerializeField] private GameObject notification;
    [SerializeField] private string[] noQuestsText;

    private bool openBook;

    public void OpenQuestBook()
    {
        openBook = !openBook; // Corrected variable name from openbook to openBook
        CreatePage();
        WriteQuests();
    }

    private void CreatePage()
    {
        if (questPage != null && notification != null)
        {
            if (openBook)
            {
                questPage.SetActive(true);
                notification.SetActive(false);
            }
            else
            {
                questPage.SetActive(false);
            }
        }
    }

    private void WriteQuests()
    {
        if (questTextBox != null)
        {
            if (MainManager.mainManager.questNames.Count == 0)
            {
                if (noQuestsText != null)
                {
                    int randomNumber = Random.Range(0, noQuestsText.Length); // Corrected variable name from noQuestsTexts to noQuestsText
                    questTextBox.text = noQuestsText[randomNumber];
                }
            }
            else
            {
                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder(); // Fully qualified namespace for StringBuilder
                foreach (string quest in MainManager.mainManager.questNames)
                {
                    stringBuilder.AppendLine(quest);
                }
                questTextBox.text = stringBuilder.ToString(); // Corrected property name from Text to text
            }
            questTextBox.rectTransform.sizeDelta = new Vector2(questTextBox.rectTransform.sizeDelta.x, questTextBox.preferredHeight); // Corrected property name from prefferedHeight to preferredHeight
        }
    }
}
