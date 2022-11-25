using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthbar : MonoBehaviour
{
    public spriteChange spriteChange;
    
    public Image angry;
    public int Number = 5;
    public Sprite[] spriteArray;
    public SpriteRenderer spr;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    //public int hits = 1;
    
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    



    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        


        //spriteRenderer.sprite = Resources.Load(tempName, typeof(Sprite)) as Sprite;
    }


  public void OnCollisionEnter2D(Collision2D collision)
    {
       Number++;
        if (Number > 2)
        {
            ResetGame();
        }
    }
  

}