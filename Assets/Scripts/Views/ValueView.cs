using System.Collections;
using System;
using TMPro;
using UnityEngine;

[Serializable]
public class ValueView
{
    [SerializeField] private TMP_Text _valueText;
    [SerializeField] private GameObject _labelGO;
    [SerializeField] private DataType _dataType;

    public DataType DataType => _dataType;

    public void SetValue(float value)
    {
        _valueText.text = String.Format("{0:0.##}", value);
    }

    public void SetType(DataType dataType)
    {
        _dataType = dataType;
    }

    public void ToggleVisible(bool isVisible)
    {
        _valueText.gameObject.SetActive(isVisible);
        if (_labelGO != null)
        {
            _labelGO.SetActive(isVisible);
        }
    }
}