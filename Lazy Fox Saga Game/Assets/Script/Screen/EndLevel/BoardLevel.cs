using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardLevel : MonoBehaviour
{
    [SerializeField]
    LoadLevel loadLevel;

    [SerializeField]
    AudioSource soundLose;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            loadLevel.RepeatLevel();
            soundLose.Play();
        }
    }
}
