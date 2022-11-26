using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteChange : MonoBehaviour
{
    public healthbar treffScript;

    public GameObject bar0;
    public GameObject bar1;
    public GameObject bar2;

    // har med tall å gjøre eksempel health bar eller damage
    public int hits = 0;

    void Update()
    {
        hits = treffScript.Number;

        if (hits == 0)
        {
            bar0.SetActive(true);
        }
        else
        {
            bar0.SetActive(false);
        }
        
        if (hits == 1)
        {
            bar1.SetActive(true);
        }
        else bar1.SetActive(false);
        
        if (hits == 2)
        {
            bar2.SetActive(true);
        }
        else bar2.SetActive(false);


    }





}
