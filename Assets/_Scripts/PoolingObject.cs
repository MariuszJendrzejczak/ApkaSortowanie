using System.Collections.Generic;
using UnityEngine;

public class PoolingObject : MonoBehaviour
{
    [SerializeField] private List<GameObject> _pooledObjects;
    [SerializeField] private GameObject _objectToPool;
    [SerializeField] private int _amountToPool;

    void Start()
    {
        _pooledObjects = new List<GameObject>();
        AddObjectsToPool(_amountToPool);
    }
    public void AddObjectsToPool(int value)
    {
        GameObject temp;
        for (int i = 0; i < value; i++)
        {
            temp = Instantiate(_objectToPool, Vector3.zero, Quaternion.identity);
            temp.transform.SetParent(transform);
            temp.SetActive(false);
            _pooledObjects.Add(temp);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < _pooledObjects.Count - 1; i++)
        {
            if (!_pooledObjects[i].activeInHierarchy)
            {
                return _pooledObjects[i];
            }
        }
        AddObjectsToPool(10);
        return GetPooledObject();
    }
}
