using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIJournalPage : MonoBehaviour
{
    [SerializeField]
    private UIJournalItem itemPrefab;

    [SerializeField]
    private RectTransform contentPanel;

    private List<UIJournalItem> listOfUIItems = new List<UIJournalItem>();

    public void InitializeJournalUI(int journalSize)
    {
        for (int i = 0; i < journalSize; i++)
        {
            UIJournalItem uiItem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
            uiItem.transform.SetParent(contentPanel, false); // Use the second parameter to keep local scale and rotation
            listOfUIItems.Add(uiItem);
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
