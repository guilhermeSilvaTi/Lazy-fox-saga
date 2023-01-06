using UnityEngine;
using UnityEngine.UI;

public class SliderSound : MonoBehaviour
{
    [SerializeField]
    Slider sliderBeggin;

    [SerializeField]
    SoundScript soundScript;
    void Start()
    {
        sliderBeggin.value = StatesGame.GetSoundFX();
    }

   public void ChangeSoundFx(Slider slider)
    {
        StatesGame.SetSoundFX(slider.value);
        soundScript.CheckSoundFX();
    }
}
