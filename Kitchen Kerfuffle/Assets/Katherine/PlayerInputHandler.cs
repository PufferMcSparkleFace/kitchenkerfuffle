using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
<<<<<<< HEAD
    private Mover mover;
=======
    private Controls controls;

    float horizontal;
  //  private float speed = 6f;
    private float jumpHeight = 25f;
    private float fallSpeed = 8f;
    private float fastFallSpeed = 50f;
  //  private bool canFastFall = false;
    private float aimRotation;
    private bool isGround;
 //   Vector2 stickRotation;
  //  Vector2 leftStickRotation;
    private bool canFire = true;
    private GameObject boomerang;
  //  private float fireRate;
  //  private float dashTime;
    private bool canDash = true;
    private int dashes = 3;
  //  private bool isDashing = false;
  //  private float dashSpeed;
  //  private float dashReloadTime;
 //   private ScoreTracker scoreTracker;
    public Animator animator;

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
        playerInput = GetComponent<PlayerInput>();
        var movers = FindObjectsOfType<TriangleControls>();

        controls = new Controls();
        controls.TriangleControls.FastFall.performed += FastFall;
        controls.TriangleControls.Jump.performed += Jump;
        controls.TriangleControls.NormalShot.performed += NormalShot;
        controls.TriangleControls.SpecialShot.performed += SpecialShot;
        controls.Enable();
        aimIndicator.enabled = false;
    }

    /* public void OnAnimatorMove(InputAction.CallbackContext obj) // FOR INPUT SYSTEM
     {
         controls = new Controls();
         controls.TriangleControls.FastFall.performed += FastFall;
         controls.TriangleControls.Jump.performed += Jump;
         controls.TriangleControls.NormalShot.performed += NormalShot;
         controls.TriangleControls.SpecialShot.performed += SpecialShot;
         controls.Enable();
         aimIndicator.enabled = false;
     } */

    private void NormalShot(InputAction.CallbackContext obj)
    {
        if (canFire == true)
        {
            //shoot boomerang
            Instantiate(boomerang, aimCursor.position, Quaternion.Euler(0f, 0f, aimRotation));
    //        animator.SetBool("isAttacking", true);
    //        StartCoroutine(playAttackAnimation());
            canFire = false;
    //        StartCoroutine(Reload());
        }
    }

    /*IEnumerator playAttackAnimation()
    {
        yield return new WaitForSeconds(0.4f);
        animator.SetBool("isAttacking", false);
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(fireRate);
        canFire = true;
        yield return null;
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
    } */

    public void SpecialShot(InputAction.CallbackContext obj) // WAS PRIVATE for players input
    {
        if (dashes != 0 && canDash == true)
        {
            //dash (not yet coded fully)
            dashes--;
            canDash = false;
     //       StartCoroutine(Dash());
        }
    }

    public void FastFall(InputAction.CallbackContext obj) //for players input 
    {
        if (!isGround && rb.velocity.y <= 0)
        {
            //fast fall, animation optional
            rb.gravityScale = fastFallSpeed;
        }
    }

    public void Jump(InputAction.CallbackContext obj) // WAS PRIVATE for players input
    {
        if (isGround)
        {
            animator.SetBool("IsJumping", true);
            //jump
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            rb.gravityScale = fallSpeed;
        }
    }
>>>>>>> parent of 3c92330 (fixing again)
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var movers = FindObjectsOfType<Mover>();
        var index = playerInput.playerIndex;
        mover = movers.FirstOrDefault(m => m.GetPlayerIndex() == index);
    }

    public void OnMove(CallbackContext context)
    {
<<<<<<< HEAD
        if (mover != null)
            mover.SetInputVector(context.ReadValue<Vector2>());
=======
        if (controls != null);
        //          controls.SetInputVector(context.ReadValue<Vector2>());
>>>>>>> parent of 3c92330 (fixing again)
    }

}