using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
//using Microsoft.Extensions.Caching.Memory.IMemoryCache;

public class Calculator : MonoBehaviour
{
    public Text Text_Calc;
    public string num;
   // private MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());

    public void On_Click_Button() {
        Text_Calc.text += num;
    }

    public void Clear() {
        Text_Calc.text = "";
    }

    public void On_Click_Equals() {
        DataTable dt = new DataTable();//Get_Or_Create("DataTable");
        Text_Calc.text = (dt.Compute(Text_Calc.text, "")).ToString();
    }

    public void Delete() {
        int lenght = Text_Calc.text.Length;
        Text_Calc.text = Text_Calc.text.Remove(lenght - 1);
    }

    /*public DataTable Create_Instance() {
        return new DataTable();
    }*/

    /*public DataTable Get_Or_Create(object key) {
        DataTable dt = null;
        if (!_cache.TryGetValue(key, out dt)) {
            dt = Create_Instance();
            Debug.Log("объект создан");

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromSecond(120));
            _cache.Set(key, dt, cacheEntryOptions);
        }
        Debug.Log("объект взят из кэша");
        return dt;
    }*/


}
