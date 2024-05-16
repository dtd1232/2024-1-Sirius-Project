using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class inputHandling : MonoBehaviour
{

    private string input;
    private bool getBool = false; 
    [SerializeField]
    private TMP_InputField inputField;

    void Update()
    {
      inputField.ActivateInputField();
      if(getBool){
			  input = "";
			  Debug.Log("setting input: " + input);
			  getBool = false;
			  Debug.Log(getBool);
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
		Debug.Log(getBool);
        return this.input;
    }
}