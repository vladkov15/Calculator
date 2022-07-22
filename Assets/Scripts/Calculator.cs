using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class Calculator : MonoBehaviour
{
    public Text Text_Calc;
    public string num;

    public void On_Click_Button() {
        Text_Calc.text += num;
    }

    public void Clear() {
        Text_Calc.text = "";
    }

    public void On_Click_Equals() {
        DataTable dt = new DataTable();
        Text_Calc.text = (dt.Compute(Text_Calc.text, "")).ToString();
    }

    public void Delete() {
        int lenght = Text_Calc.text.Length;
        Text_Calc.text = Text_Calc.text.Remove(lenght - 1);
    }

}
