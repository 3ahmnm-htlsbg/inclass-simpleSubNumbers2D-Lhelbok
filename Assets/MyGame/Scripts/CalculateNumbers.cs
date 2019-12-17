using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateNumbers : MonoBehaviour
{
    public Text result;
    public InputField valueA;
    public InputField valueB;
    public Button btn_reset;
    public Button btn_calculate;

    public void CalcResult()
    {
        result.text = ComputeNumbers().ToString();
        valueA.interactable = false;
        valueB.interactable = false;
        btn_calculate.interactable = false;
        btn_reset.interactable = true;
    }

    public void ResetResult()
    {
        valueA.text = "0";
        valueB.text = "0";
        valueA.interactable = true;
        valueB.interactable = true;
        btn_calculate.interactable = true;
        btn_reset.interactable = false;
        result.text = "Result";
    }

    private int ComputeNumbers()
    {
        int functionResult = int.Parse(valueA.text) - int.Parse(valueB.text);
        return functionResult;
    }
}
