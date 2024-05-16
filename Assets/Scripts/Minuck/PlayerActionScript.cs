using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionScript : MonoBehaviour
{
    private Rigidbody2D rigid;
    private InputCheckerScript inputCheckerScript;
    public float jumpPower = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        inputCheckerScript = GetComponent<InputCheckerScript>();
        inputCheckerScript.CorrectKeywordEventWithInput.AddListener(ActionChecker);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ActionChecker(string input)
    {
        if (input == "jump")
        {
            Jump();
        }
        else if (input == "slide")
        {
            Slide();
        }
        else if (input == "tackle")
        {
            Tackle();
        }
        else if (input == "attack")
        {
            Attack();
        }
        else if (input == "dodge")
        {
            Dodge();
        }
    }

    void Jump()
    {
        rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
    }

    void Slide()
    {

    }

    void Tackle()
    {

    }

    void Attack()
    {

    }

    void Dodge()
    {

    }
}
