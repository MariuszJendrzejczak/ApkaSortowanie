using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomList<T> : ICollection<T>
{
    public Element<T> Head { get; set; }
    public int Count { get; set; }

    private Element<T> _tmp;

    public CustomList()
    {
        Count = 0;
    }

    public void Add(Element<T> element)
    {
        var add = new AddElement<T>();
        add.Add(element, this);
    }

    public void PrintList()
    {
        int i = 0;
        if (Head == null)
        {
            Debug.Log("List is empty");
        }
        else
        {
            Debug.Log($"{i}: {Head.Value}"); // cout << i << ": " << Head.Value << endl;
            if (Head.Next == null) return;
            else
            {
                i++;
                _tmp = Head.Next;
                Debug.Log($"{i}: {_tmp.Value}");
                bool last = false;
                while (!last)
                {
                    if (_tmp.Next == null)
                    {
                        last = true;
                    }
                    else
                    {
                        i++;
                        _tmp = _tmp.Next;
                        Debug.Log($"{i}: {_tmp.Value}");
                    }
                }
            }
        }
    }
    public Element<T> GetElementAtIndex(int index)
    {
        if (index >= Count || index < 0) return null;

        _tmp = Head;
        if (index == 0) return Head;
        else
        {
            for (int i = 1; i <= index; i++)
            {
                _tmp = _tmp.Next;
            }
            return _tmp;
        }
    }
    public T GetElemetValueAtIndex(int index)
    {
        return GetElementAtIndex(index).Value;
    }

    public void RemoveAt(int index)
    {
        if (index >= Count || index < 0) return;

        _tmp = Head;
        if (index == 0)
        {
            if (Head.Next == null)
            {
                Head = null;
                return;
            }
            else
            {
                Head = Head.Next;
                Count--;
                return;
            }
        }
        else
        {
            for (int i = 1; i < index; i++)
            {
                _tmp = _tmp.Next;
            }
            if (_tmp.Next.Next != null)
            {
                _tmp.Next = _tmp.Next.Next;
                Count--;
                return;
            }
            else
            {
                _tmp.Next = null;
                Count--;
                return;
            }
        }
    }

    public void Clear()
    {
        Head = null; // cut the head off :) 
        Count = 0;
    }
}
