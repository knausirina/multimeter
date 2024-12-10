using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MultimeterConfig", menuName = "Configs/MultimeterConfig")]
public class MultimeterConfig : ScriptableObject
{
    [SerializeField] private float _r;
    [SerializeField] private float _p;
    [SerializeField] private float _acVoltage;
    [SerializeField] private MultimeterMode _defaultMode;

    public float R => _r;
    public float P => _p;
    public float ACVoltage => _acVoltage;
    public MultimeterMode DefaultMultimeterMode => _defaultMode;
}