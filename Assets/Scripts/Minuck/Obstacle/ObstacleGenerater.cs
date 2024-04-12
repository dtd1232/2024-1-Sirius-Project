using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerater : MonoBehaviour
{
    [HideInInspector] public float generateFrequency = 5.0f;
    public List<int> generateCountforEachType;

    [SerializeField] private List<GameObject> obstacleArray;
    
    
    // Start is called before the first frame update
    void Start()
    {
        generateFrequency = 5.0f;
        StartCoroutine(GenerateObstacle());

        for (int i = 0; i < obstacleArray.Count; i++)
        {
            generateCountforEachType.Add(0);
        }
    }

    IEnumerator GenerateObstacle()
    {
        while (true)  // ���� �ݺ��� ���� ���������� ��ֹ� ����
        {
            yield return new WaitForSeconds(generateFrequency);

            if (obstacleArray.Count > 0)  // ��ֹ� �迭�� ������� ������ Ȯ��
            {
                int num = Random.Range(0, obstacleArray.Count);  // ��Ȯ�� ���� �ε��� ���
                Debug.Log(num);


                Instantiate(obstacleArray[num], new Vector3(20.0f, 0.0f, 0.0f), this.transform.rotation);
                generateCountforEachType[num]++;
            }
        }
    }
}
