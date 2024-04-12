using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObstacleScript : MonoBehaviour
{

    public Dictionary<ObstaclePassKeywordsEnum, string> ObstaclePassKeywords = new Dictionary<ObstaclePassKeywordsEnum, string>() {
        { ObstaclePassKeywordsEnum.jump, "jump" },
        { ObstaclePassKeywordsEnum.slide, "slide" },
        { ObstaclePassKeywordsEnum.tackle, "tackle" },
        { ObstaclePassKeywordsEnum.attack, "attack" },
        { ObstaclePassKeywordsEnum.dodge, "dodge" },
    };


    public ObstacleTypeEnum obstacleType;

    public List<string> thisPassKeywords;

    [HideInInspector] public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        Move();
        Remove();
    }

    void Move()
    {
 
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

    void Remove()
    {
        if (transform.position.x <= -20.0f)
        {
            Destroy(this.gameObject);
        }

    }
}
