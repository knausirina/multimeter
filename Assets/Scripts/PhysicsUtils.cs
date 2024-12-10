using System.Collections;
using UnityEngine;

public static class PhysicsUtils
{
    public static float CalcI(float p, float r)
    {
        return Mathf.Sqrt(p / r);
    }

    public static float CalcDCVoltage(float p, float r)
    {
        return Mathf.Sqrt(p * r);
    }
}