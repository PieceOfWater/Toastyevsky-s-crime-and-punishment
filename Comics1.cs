using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comics1 : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false; // �������� ���������� ���������
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.enabled = true; // �������� �������� ����� ������� �������
            animator.Play("Comics1"); // �������� "AnimationName" �� �������� ����� ��������
        }
    }
}
