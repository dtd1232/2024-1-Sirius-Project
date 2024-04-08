using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerater : MonoBehaviour
{
    public float generateFrequency = 5.0f;
    
    [SerializeField] private List<GameObject> obstacleArray;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GenerateObstacle()
    {
        yield return new WaitForSeconds(generateFrequency);
    }
}
