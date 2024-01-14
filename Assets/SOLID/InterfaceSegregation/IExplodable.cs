using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IExplodable
{
    public float Mass { get; set; }
    public float ExplosiveForce { get; set; }
    public float FuseDelay { get; set; }
    public void Explode();
}
