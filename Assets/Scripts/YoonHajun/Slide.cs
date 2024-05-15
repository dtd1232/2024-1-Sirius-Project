using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    private string value;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        value = "slide";
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
