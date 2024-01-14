using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadVehicle : IMovableLiskov, ITurnable
{
    public float speed = 100f;
    public float turnSpeed = 5f;
    public virtual void GoForward()
    {

    }
    public virtual void Reverse()
    {

    }
    public virtual void TurnLeft()
    {

    }
    public virtual void TurnRight()
    {

    }
}
