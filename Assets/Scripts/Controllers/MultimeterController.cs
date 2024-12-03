using System.Collections;
using UnityEngine;

public class MultimeterController
{
    private MultimeterConfig _multimeterConfig;
    private MultimeterMode _mode;

    public MultimeterController(MultimeterConfig config)
    {
        _multimeterConfig = config;
    }

    public void SetMode(MultimeterMode multimeterMode)
    {
        _mode = multimeterMode;
    }
}