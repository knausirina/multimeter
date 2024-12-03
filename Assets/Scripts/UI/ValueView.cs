using System.Collections;
using System;
using TMPro;
using UnityEngine;

[Serializable]
public class ValueView
{
    [SerializeField] private TMP_Text[] _values;
    [SerializeField] private DataType _dataType;

    public TMP_Text[] Values => _values;
    public DataType DataType => _dataType;
}