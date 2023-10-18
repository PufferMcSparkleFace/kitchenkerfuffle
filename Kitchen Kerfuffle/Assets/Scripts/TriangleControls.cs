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
    private float jumpHeight = 25f;
    private float fallSpeed = 8f;
    private float fastFallSpeed = 50f;
    public bool canFastFall = false;
    private float aimRotation;
    Vector2 stickRotation;
    public int dashes = 3;

    [SerializeField] SpriteRenderer aimIndicator;
    [SerializeField] private Transform playerPosition;
    [SerializeField] private Transform aimFocalPoint;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;


    [SerializeField] private float dashingVelocity = 14f;
    [SerializeField] private float dashingTime = 0.5f;
    private Vector2 dashingDirection;
    private bool isDashing = false;
    private bool canDash = true;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.TriangleControls.FastFall.performed += FastFall;
        controls.TriangleControls.Jump.performed += Jump;
        controls.TriangleControls.NormalShot.performed += NormalShot;
        controls.TriangleControls.SpecialShot.performed += SpecialShot;
        controls.Enable();
        aimIndicator.enabled = false;
    }

    private void NormalShot(InputAction.CallbackContext obj)
    {

    }

    private void SpecialShot(InputAction.CallbackContext obj)
    {
        if(dashes > 0 && canDash == true)
        {
            isDashing = true;
            canDash = false;
            dashingDirection = new Vector2(stickRotation.x, stickRotation.y);
            StartCoroutine(StopDashing());
        }
    }

    private IEnumerator StopDashing()
    {
        yield return new WaitForSeconds(dashingTime);
        isDashing = false;
        dashes--;
        yield return new WaitForSeconds(0.5f);
        canDash = true;
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

        aimFocalPoint.position = playerPosition.position;

        if (isDashing == true)
        {
            rb.velocity = dashingDirection.normalized * dashingVelocity;
            return;
        }

        horizontal = controls.TriangleControls.Horizontal.ReadValue<float>();

        if (!IsGrounded())
        {
            horizontal = controls.TriangleControls.Horizontal.ReadValue<float>() * 0.85f;
        }

        stickRotation = controls.TriangleControls.Aim.ReadValue<Vector2>();

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dashes = 3;
    }
}
