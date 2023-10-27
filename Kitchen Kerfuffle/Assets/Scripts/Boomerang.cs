using UnityEngine;

public class Boomerang : MonoBehaviour
{

    [SerializeField] private GameObject triangle;
    [SerializeField] private Rigidbody2D boomerangRB;
    public float boomerangSpeed;
    public float returningSpeed;
    public int durability = 1;
    Vector3 lastVelocity;

    // Start is called before the first frame update
    void Start()
    {
        triangle = GameObject.FindGameObjectWithTag("Triangle");
        boomerangRB.AddForce(transform.up * boomerangSpeed);
    }

    private void FixedUpdate()
    {
        if (boomerangRB.velocity == Vector2.zero)
        {
            boomerangRB.drag = 0;
        }
        boomerangRB.AddForce((triangle.transform.position - transform.position) * returningSpeed * Time.deltaTime);
        lastVelocity = boomerangRB.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Triangle")
        {
            if (durability == 1)
            {
                durability--;
            }
            else
            {
                //boomerang is caught by triangle
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "Bubble" || collision.gameObject.tag == "Circle")
        {
            Destroy(gameObject);
        }

        //boomerang bounces off other boomerangs
        if (collision.gameObject.tag == "Boomerang" || collision.gameObject.tag == "Walls" || collision.gameObject.tag == "Ceiling")
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
            boomerangRB.velocity = direction * Mathf.Max(speed, 0f);
        }
    }

}
