using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpikeObstacle : ObstacleScript
{
    // Start is called before the first frame update
    void Start()
    {
        obstacleType = ObstacleTypeEnum.moving_spike;
        thisPassKeywords.Add(ObstaclePassKeywords[ObstaclePassKeywordsEnum.jump]);
    }
}
