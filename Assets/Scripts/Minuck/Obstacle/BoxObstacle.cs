using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxObstacle : ObstacleScript
{
    // Start is called before the first frame update
    void Start()
    {
        thisPassKeywords.Add(ObstaclePassKeywords["jump"]);
        thisPassKeywords.Add(ObstaclePassKeywords["tackle"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
