using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : ISort
{
    public void Sort(int[] arr)
    {
        if (arr.Length > 100000) return;
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    public void Sort(ArrayElement[] arr) 
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j].Value > arr[j + 1].Value)
                {
                    ArrayElement temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }
}
