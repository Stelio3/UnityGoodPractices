using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCalculator
{
    public float GetArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}
