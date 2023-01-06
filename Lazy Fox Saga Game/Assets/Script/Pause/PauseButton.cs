using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    [SerializeField]
    GameObject windowsPause;

    [SerializeField]
    GameObject buttonPause;

    [SerializeField]
    AudioSource music;

    public void OpenPauseMenu()
    {
        Time.timeScale = 0;
        music.volume = 0.05f;
        windowsPause.SetActive(true);
        buttonPause.SetActive(false);
    }
}
