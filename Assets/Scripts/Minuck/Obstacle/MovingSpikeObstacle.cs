using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpikeObstacle : ObstacleScript
{
    // Start is called before the first frame update
    void Start()
    {
        thisPassKeywords.Add(ObstaclePassKeywords[ObstaclePassKeywordsEnum.jump]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
