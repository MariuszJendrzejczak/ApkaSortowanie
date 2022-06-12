using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element<T>
{
    public Element(T value)
    {
        Value = value;
    }
    public T Value { get; set; }
    public Element<T> Next { get; set; }
}
