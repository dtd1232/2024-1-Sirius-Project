using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeObstacle : ObstacleScript
{

    // Start is called before the first frame update
    void Start()
    {
        obstacleType = ObstacleTypeEnum.spike;
        thisPassKeywords.Add(ObstaclePassKeywords[ObstaclePassKeywordsEnum.jump]);
    }

}
