using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteChange : MonoBehaviour
{
    // har med tall å gjøre eksempel health bar eller damage
    public int hits = 0;

    // bool fordi det er en ja eller nei statement
    public bool visible=true;
    public spriteChange dummythick;
    private GameObject treff;
     public healthbar treffScript;

    // Start is called before the first frame update
    void Start()
    {
        treff = GameObject.FindGameObjectWithTag("GameObject");
        //treffScript = healthbar.GetComponent < public void OnCollisionEnter2D(Collision2D collision)>;
        treffScript = treff.GetComponent<healthbar>();

       // treffScript.OnCollisionEnter2D(Collision2D collision);
    }

    // Update is called once per frame
    void Update()
    {
        //if (public int Number= 2)
    }





}
