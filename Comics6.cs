using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comics6 : MonoBehaviour
{
    private Animator animator;
    private int spacePressedCount = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false; // �������� ���������� ���������
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressedCount++;

            if (spacePressedCount == 6)
            {
                animator.enabled = true; // �������� �������� ����� �������� ������� �������
                animator.Play("Comics6"); // �������� "AnimationName" �� �������� ����� ��������
            }
        }
    }
}
