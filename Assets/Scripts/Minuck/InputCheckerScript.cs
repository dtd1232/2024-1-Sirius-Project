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
        input = inputField.GetComponent<InputHandlingWithEvent>().getText();
        isCorrect = false;

        // 부딪힌 대상에 ObstacleScript가 없을 경우, 즉 Enemy가 아닐 경우는 아무것도 하지 않음.
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
        CorrectKeywordEvent.Invoke();
    }

    private void CorrectKeyword(string input)
    {
        CorrectKeywordEventWithInput.Invoke(input);
    }

    private void IncorrectKeyword()
    {
        IncorrectKeywordEvent.Invoke();
    }

    private void IncorrectKeyword(string input)
    {
        IncorrectKeywordEventWithInput.Invoke(input);
    }

}
