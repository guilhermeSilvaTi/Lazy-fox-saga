using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRotation : MonoBehaviour
{
    [SerializeField]
    float velocity = 10;

    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    AudioSource moveSound;

    private float width;

    private void Start()
    {
        width = Screen.width * 0.5f;
    }

    void Update()
    {
        if (gameManager.GetIsActiveGame())
        {
            InputKeyboard();
            TouchScreen();
        }
    }

    private void TouchScreen()
    {
        Vector2 comparationPosition = Input.mousePosition; //Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
           
            if (width > comparationPosition.x)
            {
                transform.Rotate(0, 0, velocity * Time.deltaTime);
                moveSound.Play();
            }
            if (width < comparationPosition.x)
            {
                transform.Rotate(0, 0, -velocity * Time.deltaTime);
                moveSound.Play();
            }
        }

        /* for (int i = 0; i < Input.touchCount; ++i)
         {
             if (Input.GetTouch(i).phase == TouchPhase.Began)
             {
               Vector2 comparationPosition = Input.GetTouch(i).position;

                 if (width < comparationPosition.x)
                 {
                     transform.Rotate(0, 0, velocity * Time.deltaTime);
                     moveSound.Play();
                 }
                 if (width >= comparationPosition.x)
                 {
                     transform.Rotate(0, 0, -velocity * Time.deltaTime);
                     moveSound.Play();
                 }
             }
         }*/

    }

    private void InputKeyboard()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, velocity * Time.deltaTime);
            moveSound.Play();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -velocity * Time.deltaTime);
            moveSound.Play();
        }
    }
}
