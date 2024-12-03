using System.Collections;
using UnityEngine;

public class Application : MonoBehaviour
{
    [SerializeField] private MultimeterConfig _multimeterConfig;
   

    private void Awake()
    {
        var controller = new MultimeterController(_multimeterConfig);

        //var model = new ModelData(_multimeterConfig.P, _multimeterConfig.R);
    }
}