using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comics1 : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false; // анимация изначально выключена
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.enabled = true; // включаем анимацию после нажатия пробела
            animator.Play("Comics1"); // замените "AnimationName" на название вашей анимации
        }
    }
}
