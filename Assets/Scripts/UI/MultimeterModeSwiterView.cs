using System.Collections;
using UnityEngine;

public class MultimeterModeSwiterView : MonoBehaviour
{
    [SerializeField] private Transform _switcherTransform;
    [SerializeField] private GameObject BacklightGO;

    private float[] _angles = { -95.3f, -43.7f, 26.1f, 143.6f, 206.1f};
    private MultimeterMode[] _modes = { MultimeterMode.Neutral, MultimeterMode.DCVoltage, MultimeterMode.ACVoltage, MultimeterMode.Amperage};

    private int _currentMode = 0;

    private void Awake()
    {

    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
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

        if (Input.GetAxis("Mouse ScrollWheel") != 0f)
        {
            _currentMode++;
            if (_currentMode > _modes.Length)
            {
                _currentMode = 0;
            }
            var angle = _angles[_currentMode];
            _switcherTransform.localEulerAngles = new Vector3(0, angle, 0);
        }
    }
}