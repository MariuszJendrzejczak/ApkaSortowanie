using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SortingView : MonoBehaviour
{
    [SerializeField] PoolingObject _pool;
    [SerializeField] InputField _tableSizeInputField;
    [SerializeField] Button _generateBtn;
    int _poleWidth;
    int _distanceBeetweenPoles;
    int _tableSize;
    int _startingPoint;
    int[] _table;
    private void Start()
    {
        _generateBtn.onClick.AddListener(OnTableSizeChange);
        _startingPoint = Screen.width / 2 * (-1) + 100;
    }

    private void OnTableSizeChange()
    {
        if (_tableSizeInputField.text == "") return;
        _tableSize = int.Parse(_tableSizeInputField.text);
        _table = new int[_tableSize];
        TableValuesDec();
        _distanceBeetweenPoles = WidthCalkulation();
        _poleWidth = (int)(_distanceBeetweenPoles * 0.9f);
        InitTabelView();
    }
    public void InitTabelView()
    {
        int start = _startingPoint;
        foreach ( int i in _table )
        {
            GameObject pole = _pool.GetPooledObject();
            pole.SetActive(true);
            RectTransform rect = pole.GetComponent<RectTransform>();
            rect.anchoredPosition = new Vector2(start, rect.anchoredPosition.y);
            PoleView poleView = pole.GetComponent<PoleView>();
            poleView.Value = i + 1;
            poleView.SetWidth(_poleWidth);
            start += _distanceBeetweenPoles;
        }
    }
    private int WidthCalkulation()
    {
        int pixels = Screen.width - 200;
        return pixels / _tableSize; 
    }

    private void TableValuesDec()
    {
        TableValuesDec(_table);
    }
    private void TableValuesDec(int [] tab)
    {
        int tmp = tab.Length;
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = tmp;
            tmp--;
        }
    }

}
