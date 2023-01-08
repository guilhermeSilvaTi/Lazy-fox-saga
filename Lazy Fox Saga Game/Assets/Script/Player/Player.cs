using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D playerRigdbody2D;

    [SerializeField]
    Vector2 velocityDeafault;

    public void StopPlayer()
    {
        playerRigdbody2D.velocity = Vector2.zero;
        playerRigdbody2D.bodyType = RigidbodyType2D.Static;
    }

    public void GravityStop()
    {
         playerRigdbody2D.velocity = Vector2.zero; 
    }
    public void RestartGravity()
    {
        // playerRigdbody2D.bodyType = RigidbodyType2D.Dynamic;

        // playerRigdbody2D.gravityScale = gravityDefault;
      
    }

}
