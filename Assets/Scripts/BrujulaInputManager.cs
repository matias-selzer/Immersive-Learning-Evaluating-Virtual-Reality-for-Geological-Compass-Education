using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;

public class BrujulaInputManager : MonoBehaviour
{
    public InputActionReference toggleReference;
    //public Transform targetPosition;

    private bool presionandoBoton;

    // Start is called before the first frame update
    void Start()
    {
        toggleReference.action.started += Toggle;
        //transportarReference.action.started += Transportar;
    }
    private void Update()
    {
        GetComponent<RotateNeedle>().HasToRotate(!toggleReference.action.IsPressed());
    }

    private void Toggle(InputAction.CallbackContext context)
    {
       // Debug.Log("pepito");
       // GetComponent<RotateNeedle>().ToggleRotation();
    }

    private void Transportar(InputAction.CallbackContext context)
    {
        //ESTO ES CUANDO SE APRIETA EL BOTÓN A
        //transform.position = targetPosition.position;
    }



}
