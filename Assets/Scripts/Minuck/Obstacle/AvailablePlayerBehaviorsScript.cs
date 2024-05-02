using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AvailablePlayerBehaviorsScript : MonoBehaviour
{
    [SerializeField] private GameObject AvailablePlayerBehaviorPanelTemplate;

    private List<GameObject> AvailablePlayerBehaviorPanelList = new List<GameObject>();
    private Queue<GameObject> AvailablePlayerBehaviorPanelQueue = new Queue<GameObject>();
    private int maxCountOfPanalList = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            int rand = Random.Range(0, 10);
            Debug.Log(rand);
            UpdateAvailablePlayerBehaviorPanelList(rand.ToString());
        }
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
