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
    Vector2 leftStickRotation;
    public bool canFire = true;
    public GameObject boomerang;
    public float fireRate;
    public float dashTime;
    public bool canDash = true;
    public int dashes = 3;
    public bool isDashing = false;
    public float dashSpeed;
    public float dashReloadTime;
    public ScoreTracker scoreTracker;

    [SerializeField] SpriteRenderer aimIndicator;
    [SerializeField] private Transform playerPosition;
    [SerializeField] private Transform aimFocalPoint;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform aimCursor;

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
        if (canFire == true)
        {
            //shoot boomerang
            Instantiate(boomerang, aimCursor.position, Quaternion.Euler(0f, 0f, aimRotation));
            canFire = false;
            StartCoroutine(Reload());
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(fireRate);
        canFire = true;
        yield return null;
    }

    private void SpecialShot(InputAction.CallbackContext obj)
    {
        if(dashes != 0 && canDash == true)
        {
            //dash (not yet coded fully)
            dashes--;
            canDash = false;
            StartCoroutine(Dash());
        }
    }

    private void FastFall(InputAction.CallbackContext obj)
    {
        if(!IsGrounded() && rb.velocity.y <= 0)
        {
            //fast fall, animation optional
            rb.gravityScale = fastFallSpeed;
        }
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        if(IsGrounded())
        {
            //jump
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
        else
        {
            dashes = 3;
        }


        aimFocalPoint.position = playerPosition.position;

        stickRotation = controls.TriangleControls.Aim.ReadValue<Vector2>();

        if(stickRotation.x != 0 && stickRotation.y != 0)
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

    IEnumerator Dash()
    {
        isDashing = true;
        rb.gravityScale = 0;
        rb.velocity = new Vector2(0, 0);
        rb.AddForce(stickRotation * dashSpeed);
        yield return new WaitForSeconds(dashTime);
        rb.gravityScale = 8;
        isDashing = false;
        yield return new WaitForSeconds(dashReloadTime);
        canDash = true;
        yield return null;
    }

    private void FixedUpdate()
    {
        if (!isDashing)
        {
            //velocity adjusted every frame, unless dashing
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        }
        
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Boomerang")
        {
            dashes = 3;
        }
        if(collision.gameObject.tag == "Bubble")
        {
            //triangle took damage
            scoreTracker.TriangleHit();
        }
    }
}
