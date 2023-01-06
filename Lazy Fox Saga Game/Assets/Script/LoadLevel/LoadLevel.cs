using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;

    bool isActive = false;

    private const string SCENELOAD = "Level0";
    private const string MAP = "MapScene";
    private const string MENU = "MainMenu";

    public void NewLevel()
    {
        CallOtherLevel(SCENELOAD + (gameManager.GetLevel() + 1));
    }
    public void RepeatLevel()
    {
        CallOtherLevel(SceneManager.GetActiveScene().name);   
    }
    public void MapLevel()
    {
        CallOtherLevel(MAP);
    }
    public void MenuLevel()
    {
        CallOtherLevel(MENU);
    }

    public void CallLevel(int valueLevel)
    {
        CallOtherLevel(SCENELOAD + valueLevel);     
    }

    private void CallOtherLevel(string nameLevel)
    {
        if (!isActive)
        {
            Time.timeScale = 1;
            isActive = true;
            SceneManager.LoadSceneAsync(nameLevel);
        }
    }
}
