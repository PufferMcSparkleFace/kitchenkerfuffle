using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{

    [SerializeField] private GameObject triangle;
    [SerializeField] private Rigidbody2D boomerangRB;
    public float boomerangSpeed;
    public int durability = 1;

    // Start is called before the first frame update
    void Start()
    {
        triangle = GameObject.FindGameObjectWithTag("Triangle");
        boomerangRB.AddForce(transform.up * boomerangSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Triangle")
        {
            durability--;
            if(durability == 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
