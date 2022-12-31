using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;

    private const  string SCENELOAD = "Lvel0";
    private const string MAP = "MapScene";

    public void NewLevel()
    {
        SceneManager.LoadSceneAsync(SCENELOAD + (gameManager.GetLevel() +1));
    }
    public void RepeatLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }
    public void MapLevel()
    {
        SceneManager.LoadSceneAsync(MAP);

    }

}
