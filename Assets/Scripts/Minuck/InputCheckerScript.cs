using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputCheckerScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        inputField.onEndEdit.AddListener(InputChecker);
    }

    public void InputChecker(string input) {
    
        
    }

}
