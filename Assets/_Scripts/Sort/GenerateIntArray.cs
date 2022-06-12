using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateIntArray
{
    public int[] GenerateArrayReversed(int length)
    {
        int[] array = new int[length];
        int i = 0;
        for (int a = length - 1; a >= 0; a--)
        {
            array[i] = a;
            i++;
        }
        return array;
    }

    public int[] GenerateSortedArray(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }

    public int[] GenerateRandomArray(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = Random.Range(1, (int)length/2);
        }
        return array;
    }
}
