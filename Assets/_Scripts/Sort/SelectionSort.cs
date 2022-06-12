using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSort : ISort
{
    public void Sort(int[] arr)
    {
        if (arr.Length > 100000) return;
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;

            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }

    public void Sort(ArrayElement[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j].Value < arr[min_idx].Value)
                    min_idx = j;

            ArrayElement temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }
}
