using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintArray
{
    private string _result;
    
    public string ArrayToPrint(int[] arr)
    {
        _result = "";
        foreach (var item in arr)
        {
            _result += $"{item}, ";
        }
        return _result;
    }

    public string ArrayToPrint(ArrayElement[] arr)
    {
        _result = "";
        foreach (var item in arr)
        {
            _result += $"({item.Value}-{item.Index}): ";
        }
        return _result;
    }
}
