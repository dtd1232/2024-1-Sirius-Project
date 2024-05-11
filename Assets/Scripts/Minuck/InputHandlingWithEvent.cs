using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class InputHandlingWithEvent : MonoBehaviour
{
    private string input;
    [SerializeField] private TMP_InputField inputField;

    public UnityEvent<string> InputEventWithString;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();    
    }

    void Update()
    {
        inputField.ActivateInputField();


        if (Input.GetKeyDown(KeyCode.Return))
        {
            this.input = inputField.text;
            Debug.Log("Input Text: " + input);
            inputField.text = "";
            InvokeInputEventWithString(input);
        }
    }

    public string getText()
    {
        return this.input;
    }

    private void InvokeInputEventWithString(string input)
    {
        InputEventWithString.Invoke(input);
    }
}
