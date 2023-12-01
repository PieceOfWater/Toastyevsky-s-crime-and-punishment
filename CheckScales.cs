using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScales : MonoBehaviour
{
    public Rigidbody2D[] sc;
    public Fall fall;
    public GameObject BlackBox;
    public Cut cuts;

    void Update()
    {
        if(sc[0].gravityScale == 1 &&
           sc[1].gravityScale == 1 && 
           sc[2].gravityScale == 1 && 
           sc[3].gravityScale == 1 && 
           sc[4].gravityScale == 1 && 
           sc[5].gravityScale == 1 && 
           sc[6].gravityScale == 1 && 
           sc[7].gravityScale == 1 && 
           sc[8].gravityScale == 1)
        {
            fall.enabled = true;
            this.GetComponent<SpriteRenderer>().enabled = true;
            this.GetComponent<Collider2D>().enabled = true;
            this.GetComponent<Animator>().enabled = true;
            BlackBox.SetActive(true);
            cuts.enabled = true;
        }
    }
}
