﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CircleControls : MonoBehaviour
{

    Controls controls;
    float horizontal;
    private float speed = 6f;
    private float jumpHeight = 12f;
    private float fallSpeed = 2f;
    private float fastFallSpeed = 10f;
    public bool canFastFall = false;
    private float aimRotation;
    Vector2 stickRotation;

    [SerializeField] SpriteRenderer aimIndicator;
    [SerializeField] private Transform playerPosition;
    [SerializeField] private Transform aimFocalPoint;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.CircleControls.FastFall.performed += FastFall;
        controls.CircleControls.Jump.performed += Jump;
        controls.Enable();
        aimIndicator.enabled = false;
    }

    private void FastFall(InputAction.CallbackContext obj)
    {
        if (!IsGrounded() && rb.velocity.y <= 2)
        {
            rb.gravityScale = fastFallSpeed;
        }
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        if (IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            rb.gravityScale = fallSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = controls.TriangleControls.Horizontal.ReadValue<float>();

        if (!IsGrounded())
        {
            horizontal = controls.TriangleControls.Horizontal.ReadValue<float>() * 0.85f;
        }

        aimFocalPoint.position = playerPosition.position;

        stickRotation = controls.TriangleControls.Aim.ReadValue<Vector2>();

        if (stickRotation.x != 0 && stickRotation.y != 0)
        {
            aimIndicator.enabled = true;
            aimRotation = Mathf.Atan2(stickRotation.x, stickRotation.y) * -180 / Mathf.PI;
            aimFocalPoint.rotation = Quaternion.Euler(0f, 0f, aimRotation);
        }
        else
        {
            aimIndicator.enabled = false;
        }
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