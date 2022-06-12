using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertionSort : ISort
{
    public void Sort(int[] arr)
    {
        if (arr.Length > 100000) return;
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    public void Sort(ArrayElement[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            ArrayElement key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j].Value > key.Value)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
}
