using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class RotateNeedle : MonoBehaviour
{
    public GameObject aguja;
    public int x, y, z;
    private bool hasToRotate;


    // Update is called once per frame
    void Update()
    {
        if (hasToRotate)
        {
            DoRotate();
        }
    }

   /* public void ToggleRotation()
    {
        active = !active;
    }*/

    public void HasToRotate(bool toRotate)
    {
        hasToRotate = toRotate;
    }

    void DoRotate()
    {
                /*float newZ = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime).eulerAngles.z;
        Vector3 newRotation = transform.rotation.eulerAngles;
        newRotation.z = newZ;
        transform.rotation = Quaternion.Euler(newRotation);
        */
        aguja.transform.rotation = Quaternion.Slerp(aguja.transform.rotation, Quaternion.Euler(x, y, z), Time.deltaTime);
        Vector3 newRotation = aguja.transform.localRotation.eulerAngles;
        newRotation.y = 0;
        newRotation.x = 0;
        aguja.transform.localRotation = Quaternion.Euler(newRotation);
    }
}
