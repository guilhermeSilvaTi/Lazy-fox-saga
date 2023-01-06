using UnityEngine;
using UnityEngine.UI;

public class SliderMusic : MonoBehaviour
{
    [SerializeField]
    Slider sliderBeggin;

    [SerializeField]
    SoundScript soundScript;

    void Start()
    {
        sliderBeggin.value = StatesGame.GetMusic();
    }

    public void ChangeSoundFx(Slider slider)
    {
        StatesGame.SetMusic(slider.value);
        soundScript.CheckSoundMusic();
    }
}
