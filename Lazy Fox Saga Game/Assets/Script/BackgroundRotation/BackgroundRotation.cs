using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRotation : MonoBehaviour
{
    [SerializeField]
    float velocity = 10;

    // Update is called once per frame
    void Update()
    {
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
