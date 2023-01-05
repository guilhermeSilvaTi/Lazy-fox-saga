using UnityEngine;
using UnityEngine.UI;

public class SliderMusic : MonoBehaviour
{
    [SerializeField]
    Slider sliderBeggin;
    void Start()
    {
        sliderBeggin.value = StatesGame.GetMusic();
    }

    public void ChangeSoundFx(Slider slider)
    {
        StatesGame.SetMusic(slider.value);
    }
}
