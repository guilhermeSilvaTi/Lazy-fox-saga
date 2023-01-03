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

    public bool GetIsActiveGame() { return isActiveGame; }
    public void SetIsActiveGame(bool value) { isActiveGame = value; }
    public void SetLevel(int value) { level = value; }
    public int GetLevel() { return level;}

    public IEnumerator EndGame()
    {
        SetIsActiveGame(false);
        player.StopPlayer();
        yield return new WaitForSeconds(1.0f);
        mainCamera.EndGameActive();
    }
}
