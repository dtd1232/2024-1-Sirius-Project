using UnityEngine;


public class background : MonoBehaviour
{
    [SerializeField]private Transform target; //현재 배경과 이어지는 배경
    [SerializeField]private float scrollAmount; //이어지는 두 배경 사이의 거리
    [SerializeField]private float moveSpeed; //이동 속도
    [SerializeField]private Vector3 moveDirection; //이동방향
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //배경이 moveDirection 방향으로 moveSpeed의 속도로 이동
        transform.position += (moveDirection * moveSpeed * Time.deltaTime);
        
        //배경이 설정된 ㅓㅂㅁ위를 벗어나면 위치 재설정
        if (transform.position.x <= -scrollAmount)
        {
            transform.position = target.position - moveDirection * scrollAmount;
        }
    }
}
