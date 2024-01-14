using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailVehicle : IMovableLiskov
{
    public float speed = 100;
    public virtual void GoForward()
    {

    }
    public virtual void Reverse()
    {

    }
}
