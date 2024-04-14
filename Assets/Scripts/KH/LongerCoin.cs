using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongerCoin : MonoBehaviour
{
    private string input;
    [SerializeField] int coinProbability;
    private GameObject handling;
    private List<string> enemyAction;
    [HideInInspector]
    public int coin=0;
    void Start()
    {
        handling = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        input = handling.gameObject.GetComponent<inputHandling>().getText();
    }

    void OnTriggerEnter2D(Collider2D other){
        int randval;
        enemyAction = other.gameObject.GetComponent<ObstacleScript>().thisPassKeywords;
        for(int i=0; i<enemyAction.Count; i++){
            //대소문자를 무시한 input과 장애물 키워드가 같고, 키워드가 2개 이상이라면 실행됨
            if(string.Compare(input, enemyAction[i], System.StringComparison.OrdinalIgnoreCase)==0 && enemyAction.Count>=2){
                //입력한 단어가 다른 단어보다 길이가 길면 실행됨
                if(input.Length > enemyAction[(i+1)%2].Length){
                    //0~99의 숫자 중 하나를 불러오고 코인 획득 확률(coinProbability)보다 작으면 getCoin() 실행
                    randval = Random.Range(0, 100);
                    if(randval<coinProbability) GetCoin();
                }
            }
        }
    }

    void GetCoin(){
        coin++;
    }

}
