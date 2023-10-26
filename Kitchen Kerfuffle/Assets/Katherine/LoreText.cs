using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoreText : MonoBehaviour
{
    public GameObject logoText;

    void Start()
    {
        logoText.SetActive(false);
    }

    public void OnMouseOver()
    {
        logoText.SetActive(true);
    }

    public void OnMouseExit()
    {
        logoText.SetActive(false);
    }
}
