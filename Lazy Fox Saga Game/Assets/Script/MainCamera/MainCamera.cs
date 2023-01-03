using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    bool activeEndGame;

    [SerializeField]
    float YpositionEnd = 18.3f;

    [SerializeField]
    float velocity = 2;

    [SerializeField]
    private GameObject windowsEndGame;

    void Update()
    {
        if(activeEndGame)
        CheckEndGame();

    }

    private void CheckEndGame()
    {
        if (transform.position.y < YpositionEnd)
        {
            transform.Translate(Vector2.up * velocity * Time.deltaTime);
        }else
        {
            activeEndGame = false;
            windowsEndGame.SetActive(true);
        }

    }

    public void EndGameActive()
    {
        activeEndGame = true;
    }

}
