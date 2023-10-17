﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    Vector3 lastVelocity;
    public Rigidbody2D bubbleRB;
    public float bubbleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        bubbleRB = GetComponent<Rigidbody2D>();
        bubbleRB.AddForce(new Vector2(bubbleSpeed, bubbleSpeed));
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = bubbleRB.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

        bubbleRB.velocity = direction * Mathf.Max(speed, 0f);
    }
}