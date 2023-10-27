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
    public Image[] triangleHearts;
    public Image[] circleHearts;
    public GameObject[] fullHeart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triangleLives < 1)
        {
            Destroy(fullHeart[0].gameObject);
        }
        else if (triangleLives < 2)
        {
            Destroy(fullHeart[1].gameObject);
        }
        else if (triangleLives < 3)
        {
            Destroy(fullHeart[2].gameObject);
        }

        if (circleLives < 1)
        {
            Destroy(fullHeart[0].gameObject);
        }
        else if (circleLives < 2)
        {
            Destroy(fullHeart[1].gameObject);
        }
        else if (circleLives < 3)
        {
            Destroy(fullHeart[2].gameObject);
        }

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

    // Triangle Damage
    public void TriangleHit()
    {
        triangleLives--;
        Debug.Log("Triangle Hit!");

    }

    // Circle Damange
    public void CircleHit()
    {
        circleLives--;
        Debug.Log("Circle Hit!");

    }

}
