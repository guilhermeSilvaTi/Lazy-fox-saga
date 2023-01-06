
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    [SerializeField]
    AudioSource music;

    [SerializeField]
    AudioSource[] soundFXs;

    void Start()
    {
        CheckSoundMusic();
        CheckSoundFX();
    }

    public void CheckSoundMusic()
    {
        music.volume = StatesGame.GetMusic();
    }
    public void CheckSoundFX()
    {
        foreach (var item in soundFXs)
         item.volume = StatesGame.GetSoundFX();
    }
}
