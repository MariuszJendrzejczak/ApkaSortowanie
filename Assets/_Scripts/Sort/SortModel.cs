using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class SortModel 
{
    public Action<List<long>,List<Text>> OnAllDone;
    PrintArray _printArray = new PrintArray();

    List<ISort> _sortMethods = new List<ISort>()
    {
        new BubbleSort(),
        new InsertionSort(),
        new SelectionSort(),
        new HeapSort(),
        new MargeSort()
    };
    List<Task<long>> _tasks = new List<Task<long>>();
    List<long> _results = new List<long>();
    List<int[]> _list;
    List<ArrayElement[]> _list2;

    public Task SortAll(int[] arr, List<Text> results)
    {
        return SortAll(arr, OnAllDone, results);
    }
    private async Task SortAll(int[] arr, Action<List<long>,List<Text>> OnAllDone, List<Text> results)
    {
        if (_results != null)_results.Clear();
        if (_list != null) _list.Clear();
        _list = PrepareArrays(arr);

        for (int i = 0; i < 5; i++)
        {
            //UnityEngine.Debug.Log(_printArray.ArrayToPrint(_list[i]));
            await Task.Run(() =>
            {
                _results.Add(SortAsync(_sortMethods[i], _list[i]).Result);
            });
            //UnityEngine.Debug.Log(_printArray.ArrayToPrint(_list[i]));
        }
        OnAllDone?.Invoke(_results, results);
        //return;
        //for (int i = 0; i < 5; i++)
        //{
        //    UnityEngine.Debug.Log(_printArray.ArrayToPrint(_list[i]));
        //}
    }

    public async Task SortAll(ArrayElement[] arr)
    {
        if (_results != null) _results.Clear();
        _list2 = PrepareArrays(arr);
        UnityEngine.Debug.Log($"Before Sorting: {_printArray.ArrayToPrint(arr)}");
        for (int i = 0; i < 5; i++)
        {
            await Task.Run(() =>
            {
                _results.Add(SortAsync(_sortMethods[i], _list2[i]).Result);
            });
        }
        UnityEngine.Debug.Log($"Buble Sort: {_printArray.ArrayToPrint(_list2[0])}");
        UnityEngine.Debug.Log($"Insertion Sort: {_printArray.ArrayToPrint(_list2[1])}");
        UnityEngine.Debug.Log($"Selection Sort: {_printArray.ArrayToPrint(_list2[2])}");
        UnityEngine.Debug.Log($"Heap Sort: {_printArray.ArrayToPrint(_list2[3])}");
        UnityEngine.Debug.Log($"Merge Sort: {_printArray.ArrayToPrint(_list2[4])}");
    }
    private async Task<long> SortAsync(ISort sort, int[] arr)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        await Task.Run(() => sort.Sort(arr));
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
    private async Task<long> SortAsync(ISort sort, ArrayElement[] arr)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        await Task.Run(() => sort.Sort(arr));
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    private List<int[]> PrepareArrays(int[] arr)
    {
        List<int[]> list = new List<int[]>();
        for (int i = 0; i < 5; i++)
        {
            list.Add((int[])arr.Clone());
        }
        return list;
    }
    private List<ArrayElement[]> PrepareArrays(ArrayElement[] arr)
    {
        List<ArrayElement[]> list = new List<ArrayElement[]>();
        for (int i = 0; i < 5; i++)
        {
            list.Add((ArrayElement[])arr.Clone());
        }
        return list;
    }

}

