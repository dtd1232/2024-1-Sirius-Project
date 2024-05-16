using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Object/OptionData")]
public class OptionData : ScriptableObject
{
    public enum OptionType { A, B, C }

    [Header("# Main Info")]
    public OptionType optiontype;
    public int itemId;
    public string optionName;
    public string optionDesc;


}
