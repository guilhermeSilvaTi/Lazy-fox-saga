
using UnityEngine;

public class PauseClosed : MonoBehaviour
{
    [SerializeField]
    GameObject windowsPause;
    [SerializeField]
    GameObject buttonPause;
    [SerializeField]
    AudioSource music;
    [SerializeField]
    GameManager gameManager;
    public void ClodedWindows()
    {
        Time.timeScale = 1;
        gameManager.SetIsActiveGame(true);
        music.volume = StatesGame.GetMusic();
        windowsPause.SetActive(false);
        buttonPause.SetActive(true);
    }
}
