using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D playerRigdbody2D;

    public void StopPlayer()
    {
        playerRigdbody2D.velocity = Vector2.zero;
        playerRigdbody2D.bodyType = RigidbodyType2D.Static;
    }
}
