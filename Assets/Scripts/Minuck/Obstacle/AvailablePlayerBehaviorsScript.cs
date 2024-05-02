using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AvailablePlayerBehaviorsScript : MonoBehaviour
{
    [SerializeField] private GameObject AvailablePlayerBehaviorPanelTemplate;
    [SerializeField] private TMP_InputField inputField;
    private List<GameObject> AvailablePlayerBehaviorPanelList = new List<GameObject>();
    private Queue<GameObject> AvailablePlayerBehaviorPanelQueue = new Queue<GameObject>();
    private int maxCountOfPanalList = 3;

    private void Start()
    {
        inputField.onEndEdit.AddListener(UpdateAvailablePlayerBehaviorPanelList);
    }

    public void UpdateAvailablePlayerBehaviorPanelList(string keyword)
    {
        GameObject newPanel = Instantiate(AvailablePlayerBehaviorPanelTemplate, this.transform, false);
        newPanel.GetComponentInChildren<TextMeshProUGUI>().text = keyword;

        AvailablePlayerBehaviorPanelQueue.Enqueue(newPanel);

        if (AvailablePlayerBehaviorPanelQueue.Count > maxCountOfPanalList)
        {
            GameObject oldPanel = AvailablePlayerBehaviorPanelQueue.Dequeue();
            Destroy(oldPanel);
        }

        AvailablePlayerBehaviorPanelList.Clear();
        foreach (GameObject item in AvailablePlayerBehaviorPanelQueue)
        {
            AvailablePlayerBehaviorPanelList.Add(item);
        }

        for (int i = 0; i < AvailablePlayerBehaviorPanelQueue.Count; i++)
        {
            AvailablePlayerBehaviorPanelList[i].GetComponent<RectTransform>().localPosition = new Vector3(110 * i, 0, 0);
        }

    }
}
