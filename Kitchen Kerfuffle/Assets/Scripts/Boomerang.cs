using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{

    [SerializeField] private GameObject triangle;
    [SerializeField] private Rigidbody2D boomerangRB;
    public float boomerangSpeed;
    public float returningSpeed;
    public int durability = 1;

    // Start is called before the first frame update
    void Start()
    {
        triangle = GameObject.FindGameObjectWithTag("Triangle");
        boomerangRB.AddForce(transform.up * boomerangSpeed);
    }

    private void FixedUpdate()
    {
        if(boomerangRB.velocity == Vector2.zero)
        {
            boomerangRB.drag = 0;
        }
        boomerangRB.AddForce((triangle.transform.position - transform.position) * returningSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Triangle")
        {
            if(durability == 1)
            {
                durability--;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

}
