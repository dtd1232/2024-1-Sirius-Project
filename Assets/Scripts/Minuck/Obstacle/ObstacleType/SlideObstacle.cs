using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideObstacle : ObstacleScript
{
    // Start is called before the first frame update
    void Start()
    {
        obstacleType = ObstacleTypeEnum.slide;
        thisPassKeywords.Add(ObstaclePassKeywords[ObstaclePassKeywordsEnum.slide]);
    }
}
