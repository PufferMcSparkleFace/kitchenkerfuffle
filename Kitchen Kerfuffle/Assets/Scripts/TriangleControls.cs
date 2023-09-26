using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TriangleControls : MonoBehaviour
{

    Controls controls;
    float horizontal;
    private float speed = 6f;
    private float jumpHeight = 22f;
    private float shortHopHeight = 16f;
    private float fallSpeed;
    public bool canFastFall = false;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.TriangleControls.FastFall.performed += FastFall;
        controls.TriangleControls.ShortHop.performed += ShortHop;
        controls.TriangleControls.Jump.performed += Jump;
        controls.Enable();
    }

    private void ShortHop(InputAction.CallbackContext obj)
    {
        //Debug.Log("Short Hop!");
        Debug.Log(obj.control.device.displayName);
        if (IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, shortHopHeight);
            rb.gravityScale = 8f;
        }
    }

    private void FastFall(InputAction.CallbackContext obj)
    {
        //Debug.Log("draggydown");
        Debug.Log(obj.control.device.displayName);
        if(!IsGrounded() && rb.velocity.y <= 0)
        {
            rb.gravityScale = 18f;
        }
    }

    private void Jump(InputAction.CallbackContext obj)
    {
       //Debug.Log("Jump!");
        Debug.Log(obj.control.device.displayName);
        if(IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            rb.gravityScale = 8f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = controls.TriangleControls.Horizontal.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
