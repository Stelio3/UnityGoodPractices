using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

// returns the first active GameObject from the pool
public class PooledObject : MonoBehaviour
{
    private ObjectPool pool;
    public ObjectPool Pool { get => pool; set => pool = value; }
    public void Release()
    {
        pool.ReturnToPool(this);
    }
}
