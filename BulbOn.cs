using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BulbOn : MonoBehaviour
{
    private Animator animator;

    
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
     
        animator.Play("BulbOn");
        SceneManager.LoadScene("Forest1");

    }
}
