using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardLevel : MonoBehaviour
{
    [SerializeField]
    LoadLevel loadLevel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        loadLevel.RepeatLevel();
    }
}
