using System;
using System.Collections;
using UnityEngine;

public class ModelData
{
    private double _r;
    private double _i;
    private double _v;
    private double _vTemp;
    private double _p;

    public double R => _r;
    public double i => _i;
    public double v => _v;
    public double vTemp => _vTemp;
    public double r => _r;

    public ModelData(double p, double r, double vTemp)
    {
        _p = p;
        _r = r;
        _vTemp = vTemp;

        CalcA();
    }

    private void CalcA()
    {
        _i = Math.Sqrt(_p / _r);
    }
}