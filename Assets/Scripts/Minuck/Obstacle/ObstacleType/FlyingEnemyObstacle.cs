using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyObstacle : ObstacleScript
{
    // Start is called before the first frame update
    void Start()
    {
        obstacleType = ObstacleTypeEnum.flying_enemy;
        thisPassKeywords.Add(ObstaclePassKeywords[ObstaclePassKeywordsEnum.slide]);
    }
}
