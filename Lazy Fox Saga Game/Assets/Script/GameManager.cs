using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int level = 1;

    [SerializeField]
    private Player player;

    [SerializeField]
    private MainCamera mainCamera;

    private bool isActiveGame = true;

    [SerializeField]
    private GameObject UIButton;

    private bool[] coinCatch = new bool[3];

    public bool GetIsActiveGame() { return isActiveGame; }
    public void SetIsActiveGame(bool value) { isActiveGame = value; }
    public void SetLevel(int value) { level = value; }
    public int GetLevel() { return level;}

    public void SetCoinValue(int index) { coinCatch[index] = true; }

    public IEnumerator EndGame()
    {
        SetIsActiveGame(false);
        player.StopPlayer();
        UIButton.SetActive(false);
        StatesGame.SetPhaseLevel(true, level, coinCatch[0], coinCatch[1], coinCatch[2]);     
        yield return new WaitForSeconds(1.0f);
        mainCamera.EndGameActive();
    }
}
