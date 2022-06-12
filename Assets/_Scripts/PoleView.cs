using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class PoleView : MonoBehaviour
{
    private int _value;
    public int Value { get {  return _value; }
        set
        {
            _value = value;
            _rect.sizeDelta = new Vector2(_rect.sizeDelta.x, value * 50);
        } 
    }

    private RectTransform _rect;

    private void Awake()
    {
        _rect = GetComponent<RectTransform>();
    }

    public void SetWidth(int value)
    {
        _rect.sizeDelta = new Vector2(value, _rect.sizeDelta.y);
    }
}
