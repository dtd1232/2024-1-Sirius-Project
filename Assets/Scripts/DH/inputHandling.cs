using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class inputHandling : MonoBehaviour
{

    private string input;
    [SerializeField]
    private TMP_InputField inputField;

    [SerializeField]
    private Color originalColor;
    [SerializeField]
    private Color alertColor;
    private IEnumerator coroutine;

    private void Start()
    {
        coroutine = copyPasteAlert();
    }

    void Update()
    {
        inputField.ActivateInputField();

        if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl) ||
            Input.GetKeyDown(KeyCode.LeftCommand) || Input.GetKeyDown((KeyCode.RightCommand)))
        {
            StartCoroutine(copyPasteAlert());
        }

        if (Input.GetKeyDown(KeyCode.Return) ){
            saveText();
            inputField.text = "";
        }
    }

    private void saveText()
    {
        this.input = inputField.text;
        Debug.Log("Input Text: " + input);
    }

    public string getText()
    {
        return this.input;
    }

    IEnumerator copyPasteAlert()
    {
        inputField.image.color = alertColor;
        
        yield return new WaitForSeconds(1f);

        inputField.image.color = originalColor;
    }
}
