using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public Animator TAnimator;
    public Animator BAnimator;

    public int triangleLives = 3;
    public int circleLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            TriangleHit();
        }
        if(triangleLives == 0)
        {
            // death animation for triangle
            TAnimator.SetBool("Death", true); 
            Debug.Log("Triangle Loses!");
        }
        if(circleLives == 0)
        {
            // death animation for circle

            Debug.Log("Circle Loses!"); 
        }
    }

    public void TriangleHit()
    {
        triangleLives--;
        Debug.Log("Triangle Hit!");
    }

    public void CircleHit()
    {
        circleLives--;
        Debug.Log("Circle Hit!");
    }
}
