using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLevel : MonoBehaviour
{
    [SerializeField]
    bool onActive;

    [SerializeField]
    Animator animator;

    [SerializeField]
    GameObject block;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Box"))
            ActiveButton();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        DisabledButton();
    }
    private void ActiveButton()
    {
       if(!onActive)
        {
            onActive = true;
            animator.SetBool("Active", true);
            block.SetActive(false);
        }
    }
   private void DisabledButton()
    {  
            onActive = false;
            animator.SetBool("Active", false);
        block.SetActive(true);
    }
}
