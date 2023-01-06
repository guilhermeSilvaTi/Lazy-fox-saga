using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseClosed : MonoBehaviour
{
    [SerializeField]
    GameObject windowsPause;
    [SerializeField]
    GameObject buttonPause;
    [SerializeField]
    AudioSource music;
    public void ClodedWindows()
    {
        Time.timeScale = 1;
        music.volume = StatesGame.GetMusic();
        windowsPause.SetActive(false);
        buttonPause.SetActive(true);
    }
}
