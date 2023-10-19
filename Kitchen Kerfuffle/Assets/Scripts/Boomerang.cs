using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{

    [SerializeField] private GameObject triangle;

    // Start is called before the first frame update
    void Start()
    {
        triangle = GameObject.FindGameObjectWithTag("Triangle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Triangle" || collision.gameObject.tag == "Circle")
        {
            Destroy(gameObject);
        }
    }

}
