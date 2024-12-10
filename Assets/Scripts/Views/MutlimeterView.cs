using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MutlimeterView : MonoBehaviour
{
    [SerializeField] private ValueView[] _valueViews;
    [SerializeField] private ValueView _changebleView;

    private ModelData _modelData;

    private const float DefaultValue = 0f;

    public void SetData(ModelData modelData)
    {
        _modelData = modelData;
    }

    public void SetMode(MultimeterMode multimeterMode)
    {
        switch (multimeterMode)
        {
            case MultimeterMode.Neutral:
                _changebleView.SetType(DataType.None);
                SetValueOnlyForType(DataType.None);
                ToggleVisible(false);
                break;
            case MultimeterMode.Resistance:
                _changebleView.SetType(DataType.R);
                SetValueOnlyForType(DataType.R);
                ToggleVisible(true);
                break;
            case MultimeterMode.Amperage:
                _changebleView.SetType(DataType.I);
                SetValueOnlyForType(DataType.I);
                ToggleVisible(true);
                break;
            case MultimeterMode.DCVoltage:
                _changebleView.SetType(DataType.DCVoltage);
                SetValueOnlyForType(DataType.DCVoltage);
                ToggleVisible(true);
                break;
            case MultimeterMode.ACVoltage:
                _changebleView.SetType(DataType.ACVoltage);
                SetValueOnlyForType(DataType.ACVoltage);
                ToggleVisible(true);
                break;
        }
        SetValueByType(_changebleView);
    }

    private void SetValueOnlyForType(DataType dataType)
    {
        foreach (var view in _valueViews)
        {
            if (view.DataType != dataType)
            {
                view.SetValue(0);
            }
            else
            {
                SetValueByType(view);
            }
        }
    }

    private void SetValueByType(ValueView valueView)
    {
        switch (valueView.DataType)
        {
            case DataType.I:
                valueView.SetValue(_modelData.I);
                break;
            case DataType.DCVoltage:
                valueView.SetValue(_modelData.DCVoltage);
                break;
            case DataType.ACVoltage:
                valueView.SetValue(_modelData.ACVoltage);
                break;
            case DataType.R:
                valueView.SetValue(_modelData.R);
                break;
            case DataType.None:
                valueView.SetValue(DefaultValue);
                break;
        }
    }

    private void ToggleVisible(bool visible)
    {
        foreach (var view in _valueViews)
        {
            view.ToggleVisible(visible);
        }
    }
}
