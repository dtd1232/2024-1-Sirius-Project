using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObstacleScript : MonoBehaviour
{
    public enum ObstaclePassKeywordsEnum
    {
        jump,
        slide,
        tackle,
        attack,
        dodge,

    }

    public Dictionary<ObstaclePassKeywordsEnum, string> ObstaclePassKeywords = new Dictionary<ObstaclePassKeywordsEnum, string>() {
        { ObstaclePassKeywordsEnum.jump, "jump" },
        { ObstaclePassKeywordsEnum.slide, "slide" },
        { ObstaclePassKeywordsEnum.tackle, "tackle" },
        { ObstaclePassKeywordsEnum.attack, "attack" },
        { ObstaclePassKeywordsEnum.dodge, "dodge" },
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
