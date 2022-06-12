using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddElement<T>
{
    private Element<T> _tmp;
    public void Add(Element<T> element, ICollection<T> collection)
    {
        if (collection.Head == null)
        {
            collection.Head = element;
            collection.Count++;
        }
        else
        {
            if (collection.Head.Next == null)
            {
                collection.Head.Next = element;
                collection.Count++;
            }
            else
            {
                _tmp = collection.Head.Next;
                bool last = false;
                while (!last)
                {
                    if (_tmp.Next == null)
                    {
                        last = true;
                    }
                    else
                    {
                        _tmp = _tmp.Next;
                    }
                }
                _tmp.Next = element;
                collection.Count++;
            }
        }
    }
}
