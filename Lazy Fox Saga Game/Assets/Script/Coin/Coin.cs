using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    int coinValue = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            DisabledCoin();
    }

    private void DisabledCoin()
    {
        this.gameObject.SetActive(false);
    }
}
