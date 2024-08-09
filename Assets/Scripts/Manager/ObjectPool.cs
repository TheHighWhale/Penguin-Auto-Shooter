using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : MonoBehaviour
{
    public List<T> pooledObjects;
    public T prefab;
    public int poolSize;
}
