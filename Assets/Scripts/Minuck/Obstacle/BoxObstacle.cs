using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxObstacle : ObstacleScript
{
    // Start is called before the first frame update
    void Start()
    {
        thisPassKeywords.Add(ObstaclePassKeywords[ObstaclePassKeywordsEnum.slide]);
        thisPassKeywords.Add(ObstaclePassKeywords[ObstaclePassKeywordsEnum.slide]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
