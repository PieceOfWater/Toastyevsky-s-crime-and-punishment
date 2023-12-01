using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    public bool clicked;

    private void OnMouseDown()
    {
        Debug.Log("pressed");
        clicked = true;
        this.GetComponent<SpriteRenderer>().enabled = false;

        if(this.gameObject.name == "Eye")
        {
            EyesCheker script = FindObjectOfType<EyesCheker>();
            script.indexB++;
        }

        if (this.gameObject.name == "EyeR")
        {
            EyesCheker script = FindObjectOfType<EyesCheker>();
            script.indexR++;
        }

    }

}
