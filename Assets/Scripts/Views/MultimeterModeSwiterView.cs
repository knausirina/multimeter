using System;
using System.Linq;
using UnityEngine;

public class MultimeterModeSwiterView : MonoBehaviour
{
    public Action<MultimeterMode> ChangeMultimeterModeAction;

    [SerializeField] private Transform _switcherTransform;
    [SerializeField] private GameObject BacklightGO;

    private readonly float[] Angles = { -95.3f, -43.7f, 26.1f, 143.6f, 206.1f};
    private readonly MultimeterMode[] Modes = { MultimeterMode.Neutral, MultimeterMode.DCVoltage, MultimeterMode.ACVoltage, MultimeterMode.Amperage, MultimeterMode.Resistance};

    private int _currentIndex = 0;

    public void SetMode(MultimeterMode multimeterMode)
    {
        for (var i = 0; i < Modes.Length; i++)
        {
            if (Modes[i] == multimeterMode)
            {
                _currentIndex = i;
                RotateByMode();
                break;
            }
        }
    }

    private void Update()
    {
        ShowBacklight();

        ChangeModeByMouseWheel();
    }

    private void ShowBacklight()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            var layer = hit.transform.gameObject.layer;
            if (layer == Layers.Multimeter)
            {
                BacklightGO.SetActive(true);
            }
        }
        else
        {
            BacklightGO.SetActive(false);
        }
    }

    private void ChangeModeByMouseWheel()
    {
        var mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        if (mouseScroll != 0f)
        {
            if (mouseScroll > 0f)
            {
                _currentIndex++;
            }
            else
            {
                _currentIndex--;
            }

            if (_currentIndex < 0)
            {
                _currentIndex = Modes.Count() + _currentIndex;
            }

            if (_currentIndex >= Modes.Length)
            {
                _currentIndex = 0;
            }

            var newMode = Modes[_currentIndex];
            ChangeMultimeterModeAction?.Invoke(newMode);
            RotateByMode();
        }
    }

    private void RotateByMode()
    {
        var angle = Angles[_currentIndex];
        _switcherTransform.localEulerAngles = new Vector3(0, angle, 0);
    }
}