using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Robot : MonoBehaviour
{
    public int moveSpeed;
    public float searchRadius;

    //The abstract method don't contain code, MUST be override
    public abstract void FindPath();

    //the virtual method contain code, CAN be override
    public virtual void CollectResources() 
    {
        Debug.Log("This is a Robot");
    }
}
