using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public static string input;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        input = "slide";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0f,0f));

    }
}
