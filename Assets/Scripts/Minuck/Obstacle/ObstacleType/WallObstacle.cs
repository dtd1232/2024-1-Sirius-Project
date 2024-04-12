using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ObstacleScript;

public class WallObstacle : ObstacleScript
{
    // Start is called before the first frame update
    void Start()
    {
        obstacleType = ObstacleTypeEnum.wall;
        thisPassKeywords.Add(ObstaclePassKeywords[ObstaclePassKeywordsEnum.tackle]);
    }

}
