using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Windows;

public class InputCheckerScript : MonoBehaviour
{
    private string input;
    [SerializeField] private GameObject inputField;
    private List<string> enemyAction;

    public UnityEvent CorrectKeywordEvent;
    public UnityEvent<string> CorrectKeywordEventWithInput;
    public UnityEvent IncorrectKeywordEvent;
    public UnityEvent<string> IncorrectKeywordEventWithInput;

    void OnTriggerEnter2D(Collider2D other)
    {
        input = inputField.gameObject.GetComponent<inputHandling>().getText();

        enemyAction = other.gameObject.GetComponent<ObstacleScript>().thisPassKeywords;

        for (int i = 0; i < enemyAction.Count; i++)
        {
            if (string.Compare(input, enemyAction[i], System.StringComparison.OrdinalIgnoreCase) == 0)
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
        CorrectKeywordEventWithInput.Invoke(input);
    }

    private void IncorrectKeyword(string input)
    {
        IncorrectKeywordEventWithInput.Invoke(input);
    }

}
