using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGround : MonoBehaviour
{
    float timeToDisabled;

    float timeMax = 0.2f;

    float alpha = 1;

    [SerializeField]
    SpriteRenderer spriteRenderer;

    [SerializeField]
    BoxCollider2D boxCollider2D;

    private void OnCollisionStay2D(Collision2D collision)
    {
        DisabledGround();
    }

    private void DisabledGround()
    {
        timeToDisabled += Time.deltaTime * 2;
        if(timeToDisabled >= timeMax)
        {
            alpha -= 0.2f;
            timeToDisabled = 0;
            spriteRenderer.color = new Color(1, 1, 1, alpha);
            if (alpha <= 0)
                boxCollider2D.enabled = false;
          
        }
    }
}
