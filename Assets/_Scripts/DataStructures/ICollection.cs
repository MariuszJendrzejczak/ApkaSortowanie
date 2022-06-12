using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollection<T> 
{
    public Element<T> Head { get; set; }
    public int Count { get;  set; }
    public void Add(Element<T> element);
}
