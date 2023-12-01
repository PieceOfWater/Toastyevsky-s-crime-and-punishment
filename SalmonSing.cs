using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalmonSing : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        animator.Play("Salmon1");
    }
}
