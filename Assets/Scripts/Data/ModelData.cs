using System;
using System.Collections;
using UnityEngine;

public struct ModelData
{
    public float R { get; set; }
    public float I { get; set; }
    public float P { get; set; }
    public float ACVoltage { get; set; }
    public float DCVoltage { get; set; }

    public ModelData(float p, float r, float acVoltage)
    {
        P = p;
        R = r;
        ACVoltage = acVoltage;
        I = 0;
        DCVoltage = 0;
    }
}