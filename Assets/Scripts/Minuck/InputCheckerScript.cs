using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Windows;

public class InputCheckerScript : MonoBehaviour
{
    [SerializeField] private string input;
    [SerializeField] private GameObject inputField;
    private List<string> enemyAction;
    private bool isCorrect = false;

    public UnityEvent CorrectKeywordEvent;
    public UnityEvent<string> CorrectKeywordEventWithInput;
    public UnityEvent IncorrectKeywordEvent;
    public UnityEvent<string> IncorrectKeywordEventWithInput;

    void OnTriggerEnter2D(Collider2D other)
    {
        input = inputField.GetComponent<inputHandling>().getText();
        isCorrect = false;

        if (!other.gameObject.TryGetComponent<ObstacleScript>(out var obstacleScriptComponent))
        {
            return;
        }

        enemyAction = obstacleScriptComponent.thisPassKeywords;

        for (int i = 0; i < enemyAction.Count; i++)
        {
            if (string.Compare(input, enemyAction[i], System.StringComparison.OrdinalIgnoreCase) == 0)
            {
                isCorrect = true;
            }
        }

        if (isCorrect)
        {
            CorrectKeyword();
            CorrectKeyword(input);
        }
        else
        {
            IncorrectKeyword();
            IncorrectKeyword(input);
        }
    }

    private void CorrectKeyword()
    {
        Debug.Log("CorrectKeywordEvent Invoked");
        CorrectKeywordEvent.Invoke();
    }

    private void CorrectKeyword(string input)
    {
        Debug.Log("CorrectKeywordEventWithInput Invoked");
        CorrectKeywordEventWithInput.Invoke(input);
    }

    private void IncorrectKeyword()
    {
        Debug.Log("IncorrectKeywordEvent Invoked");
        IncorrectKeywordEvent.Invoke();
    }

    private void IncorrectKeyword(string input)
    {
        Debug.Log("IncorrectKeywordEventWithInput Invoked");
        IncorrectKeywordEventWithInput.Invoke(input);
    }

}
