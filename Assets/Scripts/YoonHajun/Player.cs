using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private string input;
    public float jumpPower;
    private Rigidbody2D rigid;
    private bool isJump = false;
    private bool isSlide = false;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input = inputHandling.getText();
    }

    void CanJump()
    {
        if (!isJump)
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            isJump = true;
        }
    }

    void CanSlide()
    {
        if (!isSlide)
        {
            rigid.AddForce(Vector2.down * 1, ForceMode2D.Impulse);
            isSlide = true;   
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Jump"))
        {
            if (input == Jump.input)
            {
                CanJump();
            }
            else
            {
                SceneManager.LoadScene("Main");
            }
            
        }
        else if (other.gameObject.CompareTag("Slide"))
        {
            if (input == Slide.input)
            {
                CanSlide();
            }  else
            {
                SceneManager.LoadScene("Main");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (isJump)
        {
            JumpReset();
        }

        if (isSlide)
        {
            SlideReset();
        }
        
    }

    private void JumpReset()
    {
        if (isJump)
        {
            input = "";
            Debug.Log("Input Text: " + input);
            isJump = false;
        }
    }

    private void SlideReset()
    {
        if (isSlide)
        {
            input = "";
            Debug.Log("Input Text: " + input);
            isSlide = false;
        }
    }
    

}


