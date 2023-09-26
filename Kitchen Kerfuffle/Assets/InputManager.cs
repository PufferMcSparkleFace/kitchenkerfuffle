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
        controls.TriangleControls.Jump.performed += TriangleJump;
        controls.Enable();
    }

    private void TriangleJump(InputAction.CallbackContext obj)
    {
        Debug.Log("Jump!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
