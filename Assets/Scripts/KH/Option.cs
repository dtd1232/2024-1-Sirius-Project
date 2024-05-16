using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public OptionData data;
    Text textOption;

    void Awake(){
        Text[] texts = GetComponentsInChildren<Text>();
        textOption = texts[0];
    }

    void LateUpdate(){
        textOption.text = data.optionName;
    }

    public void OnSelect(){
        switch(data.optiontype){
            case OptionData.OptionType.A:
                Debug.Log(data.optionName);
                break;
            case OptionData.OptionType.B:
                Debug.Log(data.optionName);
                break;
            case OptionData.OptionType.C:
                Debug.Log(data.optionName);
                break;
        }
    }
}
