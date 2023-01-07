using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    int coinValue = 10;

    [SerializeField]
    AudioSource sound;

    bool isDisabled = false;

    [SerializeField]
    Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !isDisabled)
           StartCoroutine( DisabledCoin());
    }

    private IEnumerator DisabledCoin()
    {
        isDisabled = true;
        StatesGame.SetScore(coinValue);
        sound.Play();
        animator.SetBool("Coin", true);
        yield return new WaitForSeconds(1.5f);
        this.gameObject.SetActive(false);
    }
}
