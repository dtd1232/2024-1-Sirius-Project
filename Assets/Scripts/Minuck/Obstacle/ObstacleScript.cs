using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObstacleScript : MonoBehaviour
{


    public Dictionary<string, string> ObstaclePassKeywords = new Dictionary<string, string>() {
        { "jump", "jump" },
        { "slide", "slide" },
        { "tackle", "tackle" },
        { "attack", "attack" },
        { "dodge", "dodge" },
    };
    public List<string> thisPassKeywords;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
