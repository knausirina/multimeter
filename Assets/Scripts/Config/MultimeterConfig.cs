using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MultimeterConfig", menuName = "Configs/MultimeterConfig")]
public class MultimeterConfig : ScriptableObject
{
    [SerializeField] private double _r;
    [SerializeField] private double _p;
    [SerializeField] private double _tempV;
    [SerializeField] private MultimeterMode _mode;

    public double R => _r;
    public double P => _p;
    public double TempV => _tempV;
    public MultimeterMode MultimeterMode => _mode;
}
