using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideObstacle : ObstacleScript
{
    // Start is called before the first frame update
    void Start()
    {
        thisPassKeywords = new List<string>
        {
            ObstaclePassKeywords[0]
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
