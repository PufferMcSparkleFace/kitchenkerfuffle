using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    Vector3 lastVelocity;
    public Rigidbody2D bubbleRB;
    public float bubbleSpeed;
    private int collisionCount;
    [SerializeField] private GameObject bubbleCentre;

    // Start is called before the first frame update
    void Start()
    {
        bubbleRB = GetComponent<Rigidbody2D>();
        bubbleRB.AddForce(transform.up * bubbleSpeed);
    }

    // Update is called once per frame
    void Update()
    {
       
        bubbleCentre = GameObject.FindGameObjectWithTag("Bubble Centre");
        lastVelocity = bubbleRB.velocity;
        bubbleRB.AddForce((bubbleCentre.transform.position - transform.position) * 15);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Triangle")
        {
            Destroy(gameObject);
        }
        else
        {
            collisionCount++;
            if(collisionCount >= 4)
            {
                Destroy(gameObject);
            }

            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
            bubbleRB.velocity = direction * Mathf.Max(speed, 0f);
        }
        
    }
}
