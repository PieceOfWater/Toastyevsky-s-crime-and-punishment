using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comics3 : MonoBehaviour
{
    private Animator animator;
    private int spacePressedCount = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false; // анимация изначально выключена
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressedCount++;

            if (spacePressedCount == 3)
            {
                animator.enabled = true; // включаем анимацию после третьего нажатия пробела
                animator.Play("Comics3"); // замените "AnimationName" на название вашей анимации
            }
        }
    }
}
