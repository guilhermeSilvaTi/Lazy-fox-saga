using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int level = 1;

    [SerializeField]
    private GameObject windowsEndGame;

    [SerializeField]
    private Player player;

    private bool isActiveGame = true;

    public bool GetIsActiveGame() { return isActiveGame; }
    public void SetIsActiveGame(bool value) { isActiveGame = value; }
    public void SetLevel(int value) { level = value; }
    public int GetLevel() { return level;}

    public void EndGame()
    {
        SetIsActiveGame(false);
        player.StopPlayer();
        windowsEndGame.SetActive(true);
    }
}
