using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KewordGuideTextScript : MonoBehaviour
{

    private List<string> keywords = new List<string>();
    private string guideText = "";
    // Start is called before the first frame update
    void Start()
    {
        keywords = GetComponentInParent<ObstacleScript>().thisPassKeywords;

        for (int i  = 0; i < keywords.Count; i++)
        {
            Debug.Log(keywords[i]);
            guideText = guideText + keywords[i] + "\n";
        }

        this.GetComponent<TextMeshPro>().text = guideText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
