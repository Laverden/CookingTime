using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


public class ConversorPanelHandler : MonoBehaviour
{
    [SerializeField]
    public TMP_InputField inputField;

    [SerializeField]
    public TMP_Dropdown inputUnitDropdown;

    [SerializeField]
    public TMP_Dropdown outputUnitDropdown;

    [SerializeField]
    public TMP_InputField outputField;

    private const float cup2Gram = 128f; // g
    private const float cup2Liter = 0.250f; // liters


    public void ConvertQuantity()
    {
        float inputValue = float.Parse(this.inputField.text);

        this.DisplayResult(inputValue);

    }

    private void DisplayResult(float outputVal)
    {
        string str_outputValue = outputVal.ToString();
        this.outputField.text = str_outputValue;
    }

    private float ComputeConversion(float inputVal, string inputUnit, string outputUnit)
    {
        float result = 0;
        
        if (inputUnit is "cup")
        {

        }

        if (inputUnit is "g")
        {

        }

        if (inputUnit is "l")
        {

        }

        return result;
    }

}
