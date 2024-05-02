using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvailablePlayerBehaviorsScript : MonoBehaviour
{
    [SerializeField] GameObject AvailablePlayerBehaviorPanelTemplate;
    [SerializeField] List<GameObject> AvailablePlayerBehaviorPanelList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateAvailablePlayerBehaviorPanelList()
    {
        for (int i = 0; i < AvailablePlayerBehaviorPanelList.Count; i++)
        {

        }
    }
}
