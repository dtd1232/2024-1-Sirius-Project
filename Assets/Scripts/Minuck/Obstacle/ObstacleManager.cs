using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [HideInInspector] public float generateFrequency = 5.0f;

    public List<int> generateCountforEachType;
    [SerializeField] private List<GameObject> obstacleArray;
    [SerializeField] private GameObject keywordGuideText;

    // Start is called before the first frame update
    void Start()
    {
        generateFrequency = 5.0f;

        for (int i = 0; i < obstacleArray.Count; i++)
        {
            generateCountforEachType.Add(0);
        }

        StartCoroutine(GenerateObstacle());
    }

    IEnumerator GenerateObstacle()
    {
        while (true)  // 무한 반복을 통해 지속적으로 장애물 생성
        {
            yield return new WaitForSeconds(generateFrequency);

            if (obstacleArray.Count > 0)  // 장애물 배열이 비어있지 않은지 확인
            {
                int num = Random.Range(0, obstacleArray.Count);  // 정확한 랜덤 인덱스 계산

                // 추후 이 부분에서 하드코딩된거 변수화 하거나 위치 조정
                GameObject obstacle = Instantiate(obstacleArray[num], new Vector3(20.0f, -3.0f, 0.0f), this.transform.rotation);

                // 처음 나오는 Obstacle이면 키워드 알려주는 텍스트 생성
                if (generateCountforEachType[num] == 0)
                {
                    GameObject keywordGuideTextasChild = Instantiate(keywordGuideText, obstacle.transform);

                    keywordGuideTextasChild.transform.localPosition = new Vector3(0, 1.5f, 0);                
                }

                generateCountforEachType[num]++;

            }
        }
    }

    public void getClearedObstacle()
    {

    }
}
