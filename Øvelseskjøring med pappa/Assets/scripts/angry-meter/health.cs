using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int Health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {

        if (Health > numOfHearts)
        {
            Health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {


            if (i < Health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            { hearts[i].enabled = true; }
            else { hearts[i].enabled = false; }
        }
    }
}
