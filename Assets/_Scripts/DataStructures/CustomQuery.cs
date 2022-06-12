using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomQuery<T> : ICollection<T>
{
    public Element<T> Head { get; set; }
    public int Count { get; set; }

    public CustomQuery()
    {
        Count = 0;
    }

    private Element<T> _tmp;

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
        return Head;
    }

    public T DequeueValue()
    {
        try
        {
            return Dequeue().Value;
        }
        catch (ArgumentNullException ex)
        {
            throw ex;
        }
    }

    public Element<T> Dequeue()
    {
        if (Head == null)
        {
            throw new ArgumentNullException("empty", "Stack is empty");
        }
        _tmp = Head;
        Head = Head.Next;
        Count--;
        return _tmp;
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
