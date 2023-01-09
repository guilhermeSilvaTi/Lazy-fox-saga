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

    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    SpriteRenderer spriteRenderer;

    [SerializeField]
    BoxCollider2D boxCollider2D;

    [SerializeField]
    int coin;

    private void Start()
    {
        AlreadyCather();  
    }

    private void AlreadyCather()
    {
        if (StatesGame.GetPhaseCoin(gameManager.GetLevel(), coin))
        {
            gameManager.SetCoinValue(coin);
            spriteRenderer.color = new Color(1, 1, 1, 0.3f);
            boxCollider2D.enabled = false;
        }
    }

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
        gameManager.SetCoinValue(coin);
        yield return new WaitForSeconds(1.5f);
        this.gameObject.SetActive(false);
    }
}
