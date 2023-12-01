using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{

    public Sprite cutj;
    public GameObject blood;
    public GameObject key;
    
    void OnMouseDown()
    {
        this.GetComponent<SpriteRenderer>().sprite = cutj;
        blood.SetActive(true);
        key.SetActive(true);
    }
}
