using System.Collections;
using UnityEngine;

public class MultimeterCalculater
{
    private MultimeterConfig _multimeterConfig;

    public MultimeterCalculater(MultimeterConfig multimeterConfig)
    {
        _multimeterConfig = multimeterConfig;
    }

    public ModelData GetCalculatedData()
    {
        var modelData = new ModelData(_multimeterConfig.P, _multimeterConfig.R, _multimeterConfig.ACVoltage);

        modelData.I = PhysicsUtils.CalcI(modelData.P, modelData.R);
        modelData.DCVoltage = PhysicsUtils.CalcDCVoltage(modelData.P, modelData.R);

        return modelData;
    }
}