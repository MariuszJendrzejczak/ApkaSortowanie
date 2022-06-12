using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SortView : MonoBehaviour
{
    [SerializeField] int _arrayLength = 100;
    [SerializeField] List<Text> _scoreTexts = new List<Text>();

    [SerializeField] List<Text> _optimisticResults = new List<Text>();
    [SerializeField] List<Text> _pesimisticResults = new List<Text>();
    [SerializeField] List<Text> _randomResults = new List<Text>();


    SortModel _sort = new SortModel();
    PrintArray _printArray = new PrintArray();
    GenerateIntArray _generateIntArray = new GenerateIntArray();
    List<long> _scores = new List<long>();

    int[] _arr;
    async void Start()
    {
        StabilityTest();
        int []arr = new int[_arrayLength];
        _sort.OnAllDone += ShowResults;
        arr = _generateIntArray.GenerateSortedArray(_arrayLength);
        await _sort.SortAll(arr, _optimisticResults);
        int[] arr2 = _generateIntArray.GenerateArrayReversed(_arrayLength);
        await _sort.SortAll(arr2, _pesimisticResults);
        int[] arr3 = _generateIntArray.GenerateRandomArray(_arrayLength);
        await _sort.SortAll(arr3, _randomResults);
        //Debug.Log(_printArray.ArrayToPrint(arr));
        //Debug.Log(_printArray.ArrayToPrint(arr2));
       // Debug.Log(_printArray.ArrayToPrint(arr3));
    }

    private void StabilityTest()
    {
        ArrayElement[] array = new ArrayElement[10]
        {
            new ArrayElement(5, 1),
            new ArrayElement(5, 2),
            new ArrayElement(5, 3),
            new ArrayElement(2, 1),
            new ArrayElement(2, 2),
            new ArrayElement(1, 1),
            new ArrayElement(10, 1),
            new ArrayElement(11, 1),
            new ArrayElement(7,1),
            new ArrayElement(7,2)  
        };
        _sort.SortAll(array);
    }

    void ResetResults()
    {
        foreach (var item in _scoreTexts)
        {
            item.text = "";
        }
    }

    private void ShowResults(List<long> results, List<Text> resultTexts)
    {
        try
        {
            for (int i = 0; i < results.Count; i++)
            {
                resultTexts[i].text = results[i].ToString() + "ms";
            }
        }
        catch (System.ArgumentOutOfRangeException ex)
        {
            //Debug.Log(ex.Message);
        }

    }
}
