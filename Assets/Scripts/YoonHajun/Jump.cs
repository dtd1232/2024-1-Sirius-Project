using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public string value;
    private float speed = 3;
    void Start()
    {
        value = "jump";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0f,0f));
    }
    
    public string GetStringValue()
    {
        return this.value;
    }
}
