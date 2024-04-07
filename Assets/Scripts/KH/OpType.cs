using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpType : MonoBehaviour
{
    [SerializeField] OptionType currentType;


    public void OnSelect()
    {
        switch(currentType){
            case OptionType.A :
                Debug.Log(currentType);
                break;
            case OptionType.B :
                Debug.Log(currentType);
                break;
            case OptionType.C : 
                Debug.Log(currentType);
                break;
        }
    }
}
