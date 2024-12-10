using System.Collections;
using UnityEngine;

public class Application : MonoBehaviour
{
    [SerializeField] private MultimeterConfig _multimeterConfig;
    [SerializeField] private MultimeterModeSwiterView _multimeterModeSwiterView;
    [SerializeField] private MutlimeterView _mutlimeterView;

    private MultimeterCalculater _multimeterCalculater;

    private void Awake()
    {
        _multimeterModeSwiterView.SetMode(_multimeterConfig.DefaultMultimeterMode);
        _multimeterModeSwiterView.ChangeMultimeterModeAction += OnChangeMultimeterModeAction;

        _multimeterCalculater = new MultimeterCalculater(_multimeterConfig);
        var modelData = _multimeterCalculater.GetCalculatedData();

        _mutlimeterView.SetData(modelData);
        _mutlimeterView.SetMode(_multimeterConfig.DefaultMultimeterMode);
    }

    private void OnChangeMultimeterModeAction(MultimeterMode multimeterMode)
    {
        _mutlimeterView.SetMode(multimeterMode);
    }
}