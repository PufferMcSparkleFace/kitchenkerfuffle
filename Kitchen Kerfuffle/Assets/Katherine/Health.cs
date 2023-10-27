using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Animator deathAnim;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Start() // when game start players are full health
    {
        health = numOfHearts;
    }

    void TakeDamage(int amount)
    {
        numOfHearts -= amount;

        if (numOfHearts <= 0)
        {
            // players dead
            //play death animation
            deathAnim.SetBool("", true);
            //show gameover panel
        }
    }

    private void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {

                hearts[i].enabled = false;
            }
        }
    }
}
