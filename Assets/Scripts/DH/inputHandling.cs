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

    void Update()
    {
        inputField.ActivateInputField();    
        

        if (Input.GetKeyDown(KeyCode.Return) ){
            saveText();
            inputField.text = "";
        }
    }

    private void saveText()
    {
        input = inputField.text;
        Debug.Log("Input Text: " + input);
    }

    public string getText()
    {
        return this.input;
    }
}