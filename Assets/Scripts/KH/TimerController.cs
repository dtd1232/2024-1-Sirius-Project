using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField] GameObject trialEnded;
    [SerializeField] Image linearForeground;
    [SerializeField] GameObject toMainButton;
    private float currentTime;
    [SerializeField] float maxTime = 120.0f;
    private IEnumerator coroutine;
    void Start()
    {
        StartCoroutine(waitTime());
    }

    void Awake(){
        currentTime = 0;
    }


    public IEnumerator waitTime(){
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

    public void toMain(){
        SceneManager.LoadScene("KH_Scene");
    }
}
