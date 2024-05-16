using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class InputHandlingWithEvent : MonoBehaviour
{
    private string input;
    [SerializeField] private TMP_InputField inputField;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();    
    }

    void Update()
    {
        inputField.ActivateInputField();
    }

    public string getText()
    {
        return this.input;
    }

    public void SaveText(string input)
    {
        this.input = input;
        Debug.Log("Input Text: " + input);
        inputField.text = "";
    }
}
