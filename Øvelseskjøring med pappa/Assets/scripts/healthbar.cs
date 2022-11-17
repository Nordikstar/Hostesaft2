using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Image angry;
    public int number = 1;
    public Sprite[] spriteArray;
    public SpriteRenderer spr;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }


  private void OnCollisionEnter2D(Collision2D collision)
    {
        number++;
    }

  
}


