using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongerCoin : MonoBehaviour
{
    public string input;
    public long int coin=0;
    public List<string> passKeyword;    
    [SerializeField] int coinProbability;
    public GameObject inputHandling;
    void Start()
    {
        inputHandling = GameObject.find("Canvas"); //"inputhanling이 있는 canvas/inputhandler" 같은 scene에 존재하거나 gamemanager 비슷한게 있어야 함
    }

    // Update is called once per frame
    void Update()
    {
        input = inputHandling.GameObject.GetComponent<inputHandling>.input;
    }

    void OncollisionEnter(Collision other){
        Random randGen = new Random();
        private int randval;
        enemyAction = other.gameObject.GetComponent<enemy>().thisPassKeywords.ToList();
        for(int i=0; i<enemyAction.Count; i++){
            if(string.Compare(input, enemyAction[i], true)==0 && enemyAction.Length()>=2){
                if(input.Length > enemyAction[(i+1)%2]){
                    randval = randGen(0, 100);
                    if(ranval<coinProbability) GetCoin();
                }
            }
        }
        
    }

    void GetCoin(){
        coin++;
    }
}
