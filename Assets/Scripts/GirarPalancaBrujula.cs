using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GirarPalancaBrujula : MonoBehaviour
{
    public GameObject palanca;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        CheckStickMovement();
    }

    void CheckStickMovement()
    {
        var devices = new List<UnityEngine.XR.InputDevice>();
        InputDeviceCharacteristics leftcontrollerdesiredCharacteristics = UnityEngine.XR.InputDeviceCharacteristics.HeldInHand | UnityEngine.XR.InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(leftcontrollerdesiredCharacteristics, devices);

        //Debug.Log(devices.Count);

        if (devices.Count == 2)
        {
            //UnityEngine.XR.InputDevice device = devices[0];

            Vector2 inputValueLeft;
            Vector2 inputValueRight;
            //if (device.TryGetFeatureValue(CommonUsages.primaryButton, out inputValue) && inputValue);
            devices[0].TryGetFeatureValue(CommonUsages.primary2DAxis, out inputValueLeft);
            devices[1].TryGetFeatureValue(CommonUsages.primary2DAxis, out inputValueRight);

            //Debug.Log(inputValueLeft.x);

            palanca.transform.Rotate(0, 0, inputValueRight.x);

            Vector3 currentRotation = palanca.transform.localRotation.eulerAngles;
            float z = currentRotation.z;
            z = Mathf.Max(90, Mathf.Min(z, 270));
            currentRotation.z = z;

            palanca.transform.localRotation = Quaternion.Euler(currentRotation);
            
        }
    }


}
