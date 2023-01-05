using UnityEngine.SceneManagement;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    private const string MAIN = "MainMenu";
    void Start()
    {
        StatesGame.CallStatesGame();
        SceneManager.LoadSceneAsync(MAIN);
    }

}
