using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    Controls controls; 

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.TriangleControls.Jump.performed += Jump;
        controls.TriangleControls.FastFall.performed += FastFall;
        controls.Enable();
    }

    private void FastFall(InputAction.CallbackContext obj)
    {
        Debug.Log("draggydown");
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        Debug.Log("Jump!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
