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
        loadLevel.RepeatLevel();
        soundLose.Play();
    }
}
