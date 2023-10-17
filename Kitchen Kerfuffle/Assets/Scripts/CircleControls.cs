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
    private float jumpHeight = 9f;
    private float fallSpeed = 1f;
    private float aimRotation;
    public bool canJump = false;
    Vector2 stickRotation;
    public float fireRate;
    public bool canFire;
    public GameObject bubble;

    [SerializeField] SpriteRenderer aimIndicator;
    [SerializeField] private Transform playerPosition;
    [SerializeField] private Transform aimCursor;
    [SerializeField] private Transform aimFocalPoint;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.CircleControls.Jump.performed += Jump;
        controls.CircleControls.NormalShot.performed += NormalShot;
        controls.Enable();
        aimIndicator.enabled = false;
    }

    private void NormalShot(InputAction.CallbackContext obj)
    {
        if(canFire == true)
        {
            Instantiate(bubble, aimCursor.position, Quaternion.Euler(new Vector3(0, 0, aimFocalPoint.transform.rotation.z)));
            canFire = false;
            aimIndicator.enabled = false;
            StartCoroutine(Reload());
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(fireRate);
        canFire = true;
        aimIndicator.enabled = true;
        yield return null;
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        if (IsGrounded() || canJump == true)
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
            aimRotation = Mathf.Atan2(stickRotation.x, stickRotation.y) * -180 / Mathf.PI;
            aimFocalPoint.rotation = Quaternion.Euler(0f, 0f, aimRotation);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bubble Trigger")
        {
            canJump = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bubble Trigger")
        {
            canJump = false;
        }
    }
}