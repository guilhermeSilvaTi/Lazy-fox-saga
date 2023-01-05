using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLevel : MonoBehaviour
{
    [SerializeField]
    bool moveToRight;
    [SerializeField]
    bool moveToLeft;

    [SerializeField]
    float[] PositionX;

    [SerializeField]
    int section;
    int maxSection = 2;

    [SerializeField]
    float velocity = 2;

    private void Update()
    {
        CheckDirection();
    }

    private void CheckDirection()
    {
        if (moveToRight)
        {
            if (transform.position.x > PositionX[section+1])
                transform.Translate(Vector2.left * velocity * Time.deltaTime);
            else
            {
                moveToRight = false;            
                section++;
            }
        }
        else
        {
            if (moveToLeft)
            {
                if (transform.position.x < PositionX[section-1])
                    transform.Translate(Vector2.right * velocity * Time.deltaTime);
                else
                {
                    moveToLeft = false;
                    section--;
                }
            }
        }
    }

    internal void RightController()
    {
        if (section < maxSection)
        {
            moveToRight = true;
            moveToLeft = false;
        }
    }

    internal void LeftController()
    {
        if (section > 0)
        {
            moveToRight = false;
            moveToLeft = true;
        }
    }
}
