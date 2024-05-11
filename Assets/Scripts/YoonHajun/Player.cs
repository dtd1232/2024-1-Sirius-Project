using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private inputHandling _inputHandling;
    private string input = "";
    private Rigidbody2D rigid;
    private bool isJump = false;
    private bool isSlide = false;
    private bool canMove = false; // 플레이어가 움직일 수 있는지 여부를 나타내는 플래그

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        _inputHandling = gameObject.AddComponent<inputHandling>();        
    }

    void Update()
    {
        input = _inputHandling.getText();
    }

    void Jump()
    {
        rigid.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        isJump = true; // 점프 했음을 표시
        ResetNextAction();
    }

    void Slide()
    {
        // Slide 동작 수행 후 다음 행동을 재설정
        isSlide = true;
        ResetNextAction();
    }

    void ResetNextAction()
    {
        // 다음 행동 리셋
        input = "";
        isJump = false; // 점프 상태 초기화
        isSlide = false; // 슬라이드 상태 초기화
        canMove = false;
    }

    void Die()
    {
        // 게임 재시작
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // 현재 Scene 재로딩 대신, 게임 내에서 필요한 처리를 하거나 게임 매니저에 재시작을 요청하는 등의 작업을 수행해야 합니다.
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Jump jumpEnemy = other.gameObject.GetComponent<Jump>();
            Slide slideEnemy = other.gameObject.GetComponent<Slide>();
            if (input == jumpEnemy.GetStringValue()) {
                Jump();
            } else if (input == slideEnemy.GetStringValue()) {
                Slide();
            } else {
                Die();
            }
        }
    }
}