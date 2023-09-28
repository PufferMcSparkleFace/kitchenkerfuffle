﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TriangleControls : MonoBehaviour
{

    Controls controls;
    float horizontal;
    private float speed = 6f;
    private float jumpHeight = 25f;
    private float fallSpeed = 8f;
    private float fastFallSpeed = 50f;
    public bool canFastFall = false;

    [SerializeField] private Transform playerPosition;
    [SerializeField] private Transform aimFocalPoint;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.TriangleControls.FastFall.performed += FastFall;
        controls.TriangleControls.Jump.performed += Jump;
        controls.Enable();
    }

    private void FastFall(InputAction.CallbackContext obj)
    {
        if(!IsGrounded() && rb.velocity.y <= 0)
        {
            rb.gravityScale = fastFallSpeed;
        }
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        if(IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            rb.gravityScale = fallSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = controls.TriangleControls.Horizontal.ReadValue<float>();
        aimFocalPoint.position = playerPosition.position;
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
