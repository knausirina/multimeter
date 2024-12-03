using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Collections;
using System;
using TMPro;

public class MutlimeterView : IndicatorsView
{
    [SerializeField] private TMP_Text _multimeterText;

    [SerializeField] private GameObject _gameObject;

    private MultimeterConfig _multimeterConfig;

    public void Construct(MultimeterConfig multimeterConfig)
    {
        _multimeterConfig = multimeterConfig;
    }

    public void SetValue(float value)
    {
        _multimeterText.text = string.Format("%.2f", value);

    }

    [ContextMenu("Rotate")]
    public void Rotate()
    {
        Debug.Log("xxx Rotate");

        //Vector3 position = _gameObject.GetComponent<Renderer>().bounds.center;
        var position = new Vector3(16.4f, -29.3f, 134.4001f);
        _gameObject.transform.RotateAround(position, Vector3.up,10);
    }
}
