using System;
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
    private bool isGround;
    public bool canJump = false;
    Vector2 stickRotation;
    public float fireRate;
    public bool canFire;
    public GameObject bubble;
    public ScoreTracker scoreTracker;

    //(Sally)
    public Animator animator;

    [SerializeField] SpriteRenderer aimIndicator;
    [SerializeField] private Transform playerPosition;
    [SerializeField] private Transform aimCursor;
    [SerializeField] private Transform aimFocalPoint;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private GameObject bubbleCentre;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.CircleControls.Jump.performed += Jump;
        controls.CircleControls.NormalShot.performed += NormalShot;
        controls.CircleControls.SpecialShot.performed += SpecialShot;
        controls.Enable();
        aimIndicator.enabled = false;
    }

    private void SpecialShot(InputAction.CallbackContext obj)
    {
        if (canFire == true)
        {
            //call bubble animation


            bubbleCentre.SetActive(true);
            StartCoroutine(Deactivate());
            canFire = false;
            StartCoroutine(Reload());
        }
    }

    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(0.01f);
        bubbleCentre.SetActive(false);
        yield return null;
    }

    private void NormalShot(InputAction.CallbackContext obj)
    {
        if(canFire == true)
        {
            //shoot bubble animation
            animator.SetBool("IsAttacking", true);
            StartCoroutine(attackAnimation());
            Instantiate(bubble, aimCursor.position, Quaternion.Euler(0f, 0f, aimRotation));
            canFire = false;
            
            StartCoroutine(Reload());
        }
    }

    IEnumerator attackAnimation()
    {
        yield return new WaitForSeconds(0.01f);
        animator.SetBool("IsAttacking", false);
    }

    IEnumerator Reload()
    {
        
        yield return new WaitForSeconds(fireRate);
        canFire = true;
        yield return null;
        
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        if (canJump == true)
        {
            animator.SetBool("IsJumping", true);
            //jump
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            rb.gravityScale = fallSpeed;

            
        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = controls.TriangleControls.Horizontal.ReadValue<float>();

        //(Sally)
        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        /*
            if (!IsGrounded())
        {
            horizontal = controls.TriangleControls.Horizontal.ReadValue<float>() * 0.85f;

        }
        */

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
        //adjusting velocity every frame
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        bool wasGrounded = isGround;
        isGround = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 0.2f, groundLayer);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                isGround = true;
                if (!wasGrounded)
                    animator.SetBool("IsJumping", false);
            }
        }
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Boomerang")
        {
            //circle took damage
            scoreTracker.CircleHit();
            Debug.Log("circle was hit");
            //(Sally) idk about this
            animator.SetBool("IsHit", true);
            animator.SetBool("IsHit", false);
        }
    }
}