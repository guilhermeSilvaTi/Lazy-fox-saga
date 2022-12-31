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

    // Update is called once per frame
    void Update()
    {
        if(gameManager.GetIsActiveGame())
        InputKeyboard();
    }

    private void InputKeyboard()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        transform.Rotate(0, 0, velocity * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, 0, -velocity * Time.deltaTime);
    }
}
