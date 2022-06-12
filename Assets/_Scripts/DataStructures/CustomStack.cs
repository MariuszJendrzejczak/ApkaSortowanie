using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomStack<T> :ICollection<T>
{
    public Element<T> Head { get; set; }
    public int Count { get; set; }

    private Element<T> _tmp;
    private Element<T> _tmp2;


    public CustomStack()
    {
        Count = 0;
    }
    public void Add(Element<T> element)
    {
        var add = new AddElement<T>();
        add.Add(element, this);
    }
    public T PeekValue()
    {
        try
        {
            return Peek().Value;
        }
        catch (ArgumentNullException ex)
        {
            throw ex;
        }
    }
    public Element<T> Peek()
    {
        if (Head == null)
        {
            throw new ArgumentNullException("empty", "Stack is empty");
        }
        _tmp = Head;
        for (int i = 1; i < Count; i++)
        {
            _tmp = _tmp.Next;
        }
        return _tmp;
    }

    public T PopValue()
    {
        try
        {
            return Pop().Value;
        }
        catch (ArgumentNullException ex)
        {
            throw ex;
        }
    }
    public Element<T> Pop()
    {
        if (Head == null)
        {
            throw new ArgumentNullException("empty", "Stack is empty");
        }
        if (Count == 1)
        {
            _tmp = Head;
            Head = null;
            Count--;
            return _tmp;
        }
        _tmp = Head;
        for (int i = 1; i < Count -1; i++)
        {
            _tmp = _tmp.Next;
        }
        _tmp2 = _tmp.Next;
        _tmp.Next = null;
        Count--;
        return _tmp2;
    }

    public void Clear()
    {
        if (Head == null)
        {
            throw new ArgumentNullException("empty", "Stack is empty");
        }
        Head = null;
        Count = 0;
    }
}
