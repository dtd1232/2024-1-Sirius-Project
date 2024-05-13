using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.String;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private inputHandling _inputHandling;
    private string input = "";
    private Rigidbody2D rigid;
    private bool isJump;
    private bool isSlide;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        input = _inputHandling.getText();
    }

    void Jump()
    {
        if (isJump)
        {
            rigid.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            ResetNextAction();
        }
    }

    void Slide()
    {
        // Slide 동작 수행 후 다음 행동을 재설정
        if (isSlide)
        {
            ResetNextAction();
        }
    }

    void ResetNextAction()
    {
        input = "";
        isJump = false;
        isSlide = false;
    }

    void Die()
    {
        // 게임 재시작
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // 현재 Scene 재로딩 대신, 게임 내에서 필요한 처리를 하거나 게임 매니저에 재시작을 요청하는 등의 작업을 수행해야 합니다.
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Jump jumpEnemy = other.gameObject.GetComponent<Jump>();
        Slide slideEnemy = other.gameObject.GetComponent<Slide>();
        
        
        if (jumpEnemy != null && input == jumpEnemy.GetStringValue())
        { 
            isJump = true;
            Jump();
        } 
        else if (slideEnemy != null && input == slideEnemy.GetStringValue())
        {
            isSlide = true;
            Slide();
        }
        else
        {
            Die();
        }

        ResetNextAction();
    }
}