using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStructures : MonoBehaviour
{
    CustomList<string> _list = new CustomList<string>();
    CustomStack<string> _stack = new CustomStack<string>();
    CustomQuery<string> _queue = new CustomQuery<string>();
    void Start()
    {
        //queue
        //AddSixElementsToICollection(_queue);
        //int count = _queue.Count;   
        //for (int i = 0; i < count; i++)
        //{
        //    Debug.Log("Pick: " + _queue.PeekValue());
        //    Debug.Log("Pop: " + _queue.DequeueValue());
        //}
        //try
        //{
        //    _queue.Dequeue();
        //}
        //catch (System.Exception ex)
        //{
        //    Debug.Log(ex.Message);
        //}
        //AddSixElementsToICollection(_queue);
        //Debug.Log("Pick: " + _queue.PeekValue());
        //_queue.Clear();  
        //try
        //{
        //    _queue.Dequeue();
        //}
        //catch (System.Exception ex)
        //{
        //    Debug.Log(ex.Message);
        //}

        // stack
        //AddSixElementsToICollection(_stack);
        //count = _stack.Count;
        //for (int i = 0; i < count; i++)
        //{
        //    Debug.Log("Pick: " + _stack.PeekValue());
        //    Debug.Log("Pop: " + _stack.PopValue());
        //}
        //try
        //{
        //    _stack.Pop(); // exeption
        //}
        //catch (System.ArgumentNullException ex)
        //{
        //    Debug.Log(ex.Message);
        //}
        //AddSixElementsToICollection(_stack);
        //Debug.Log("Pick: " + _stack.PeekValue());
        //_stack.Clear();
        //try
        //{
        //    _stack.Peek(); // exeption
        //}
        //catch (System.ArgumentNullException ex)
        //{
        //    Debug.Log(ex.Message);
        //}

        // list
        //AddSixElementsToICollection(_list);
        //_list.PrintList(); // ca³a lista 1-6
        //Element<string> e1 = _list.GetElementAtIndex(3);
        //Debug.Log(e1.Value); // 4
        //Debug.Log(_list.GetElemetValueAtIndex(2));  // 3
        //_list.RemoveAt(3); // - usuówam 4
        //_list.PrintList(); // 1, 2, 3, 5, 6
        //_list.Clear();
        //_list.PrintList();

    }

    void AddSixElementsToICollection(ICollection<string> collection)
    {
        collection.Add(new Element<string>("jeden"));
        collection.Add(new Element<string>("dwa"));
        collection.Add(new Element<string>("trzy"));
        collection.Add(new Element<string>("cztery"));
        collection.Add(new Element<string>("piec"));
        collection.Add(new Element<string>("szesc"));
    }
}
