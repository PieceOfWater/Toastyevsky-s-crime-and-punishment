using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    private Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); 
        if (moveX != 0)
        {
            animator.Play("ToastRight");
        } else animator.Play("Idle");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();  
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime); 

        if(moveX < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        } else GetComponent<SpriteRenderer>().flipX = false;

    }
}
