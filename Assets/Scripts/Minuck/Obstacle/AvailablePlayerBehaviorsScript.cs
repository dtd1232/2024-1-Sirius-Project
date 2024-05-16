using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AvailablePlayerBehaviorsScript : MonoBehaviour
{
    [SerializeField] private GameObject AvailablePlayerBehaviorPanelTemplate;
    [SerializeField] private InputCheckerScript inputCheckerScript;
    private List<GameObject> AvailablePlayerBehaviorPanelList = new();
    private List<string> AvailablePlayerBehaviorStringList = new();


    private void Start()
    {
        inputCheckerScript.CorrectKeywordEventWithInput.AddListener(UpdateAvailablePlayerBehaviorPanelList);
    }

    public void UpdateAvailablePlayerBehaviorPanelList(string keyword)
    {
        if (!AvailablePlayerBehaviorStringList.Contains(keyword))
        {
            AvailablePlayerBehaviorStringList.Add(keyword);

            GameObject newPanel = Instantiate(AvailablePlayerBehaviorPanelTemplate, this.transform, false);
            newPanel.GetComponentInChildren<TextMeshProUGUI>().text = keyword;
            AvailablePlayerBehaviorPanelList.Add(newPanel);
        }

        for (int i = 0; i < AvailablePlayerBehaviorPanelList.Count; i++)
        {
            AvailablePlayerBehaviorPanelList[i].GetComponent<RectTransform>().localPosition = new Vector3(90 * i, 0, 0);
        }

    }
}
