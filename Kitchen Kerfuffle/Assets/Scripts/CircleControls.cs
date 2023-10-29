using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class CircleControls : MonoBehaviour
{

    Controls controls;
    private float horizontal;
    private float speed = 6f;
    private float jumpHeight = 9f;
    private float fallSpeed = 1f;
    private float aimRotation;

    public bool canJump = false;
    Vector2 stickRotation;
    public float fireRate;
    public bool canFire;
    public GameObject bubble;
    public ScoreTracker scoreTracker;

    //for mouse aim
    /*public Camera mainCam;
    private Vector3 mousePos;*/

    //(Sally)
    public Animator animator;

    [Header("---------Circle Movements")]
    [SerializeField] SpriteRenderer aimIndicator;
    [SerializeField] private Transform playerPosition;
    [SerializeField] private Transform aimCursor;
    [SerializeField] private Transform aimFocalPoint;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private GameObject bubbleCentre;

    [Header("---------Circle SFX")]
    [SerializeField] private AudioSource CJumpSFX;
    [SerializeField] private AudioSource CDeathSFX;
    [SerializeField] private AudioSource CNormalShotSFX;
    [SerializeField] private AudioSource CSpecialShotSFX;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.CircleControls.Jump.performed += Jump;
        controls.CircleControls.NormalShot.performed += NormalShot;
        controls.CircleControls.SpecialShot.performed += SpecialShot;
        controls.Enable();
        aimIndicator.enabled = false;

     //   mainCam = GameObject.FindGameObjectWithTag("Main Camera").GetComponent<Camera>();
    }

    public void SpecialShot(InputAction.CallbackContext obj) // WAS PRIVATE void
    {
        if (canFire == true)
        {
            CSpecialShotSFX.Play();
            //call bubble animation
            animator.SetBool("IsSummoning", true);
            StartCoroutine(summonAnimation());

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
    IEnumerator summonAnimation()
    {
        yield return new WaitForSeconds(0.01f);
        animator.SetBool("IsSummoning", false);
    }

    public void NormalShot(InputAction.CallbackContext obj) //WAS PRIVATE void
    {
        if (canFire == true)
        {
            CNormalShotSFX.Play();
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

     public void Horizontal(InputAction.CallbackContext obj)
     {
         horizontal = controls.CircleControls.Horizontal.ReadValue<float>();
         horizontal = controls.CircleControls.Horizontal.ReadValue<float>();

         if (!IsGrounded())
         {
             horizontal = controls.CircleControls.Horizontal.ReadValue<float>() * 0.85f;

         }

     }


    public void Aim(InputAction.CallbackContext obj)
    {
        //mouse aim

        /*aimIndicator.enabled = true;
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ); */

        aimFocalPoint.position = playerPosition.position;
        stickRotation = controls.CircleControls.Aim.ReadValue<Vector2>();
    }

    public void Jump(InputAction.CallbackContext obj) //WAS PRIVATE
    {
        if (canJump == true)
        {
            CJumpSFX.Play();
            canJump = false;
            //jump
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            rb.gravityScale = fallSpeed;

            animator.SetBool("IsJumping", true);
            StartCoroutine(jumpAnimation());

        }
    }


    IEnumerator jumpAnimation()
    {
        yield return new WaitForSeconds(0.01f);
        animator.SetBool("IsJumping", false);
    }

    // Update is called once per frame
    void Update()
    {


        horizontal = controls.CircleControls.Horizontal.ReadValue<float>();

        //(Sally)
        animator.SetFloat("Speed", Mathf.Abs(horizontal));


        if (!IsGrounded())
        {
            horizontal = controls.CircleControls.Horizontal.ReadValue<float>() * 0.85f;

        }

        //mouse aim
    
        /*aimIndicator.enabled = true;
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ); */

        aimFocalPoint.position = playerPosition.position;
        stickRotation = controls.CircleControls.Aim.ReadValue<Vector2>();

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

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void FixedUpdate()
    {
        //adjusting velocity every frame
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        /*
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
        */
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
        if (collision.gameObject.tag == "Bubble Trigger" && !IsGrounded())
        {
            canJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boomerang")
        {
            //circle took damage
            CDeathSFX.Play();
            scoreTracker.CircleHit();
            Debug.Log("circle was hit");
            //(Sally) idk about this
            animator.SetBool("IsHit", true);
            StartCoroutine(hitAnimation());
        }

        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }

    IEnumerator hitAnimation()
    {
        yield return new WaitForSeconds(0.01f);
        animator.SetBool("IsHit", false);
    }
}