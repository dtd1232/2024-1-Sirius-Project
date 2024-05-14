using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject trialEnded;
    [SerializeField] Image linearForeground;
    [SerializeField] GameObject toMainButton;
    [SerializeField] GameObject gameOver;
    private float currentTime;
    [SerializeField] float maxTime = 120.0f;
    private IEnumerator coroutine;
    private bool isCorrect;
    void Start()
    {
        coroutine = progress();
        StartCoroutine(coroutine);
        player = GameObject.Find("Player");
    }

    void Awake(){
        currentTime = 0;
    }

    void Update(){
        isCorrect = player.gameObject.GetComponent<LongerCoin>().IsCorrectKeyword();
        if(isCorrect==false) {
            Debug.Log("Gameover");
            GameOver();
        }
    }


    public IEnumerator progress(){
        while(currentTime<maxTime){
            currentTime += Time.deltaTime;
            linearForeground.fillAmount = currentTime/maxTime;
            yield return new WaitForSeconds(Time.deltaTime);
        }
        trialEnded.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        trialEnded.SetActive(false);
        toMainButton.SetActive(true);
    }

    public void ToMain(){
        SceneManager.LoadScene("KH_Scene");
    }

    public void GameOver(){
        StopCoroutine(progress());
        gameOver.SetActive(true);
        Invoke("toMain", 2);
    }
}
