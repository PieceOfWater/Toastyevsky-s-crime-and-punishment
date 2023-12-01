using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOn : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.gravityScale = 1;
        }
    }
}
