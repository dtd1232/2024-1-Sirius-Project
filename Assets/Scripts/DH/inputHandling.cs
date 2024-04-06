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

    public void saveText()
    {
        this.input =  inputField.text;
        Debug.Log("Input Text: " + input);
    }
}
