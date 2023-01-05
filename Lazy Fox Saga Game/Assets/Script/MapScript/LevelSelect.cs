
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class LevelSelect : MonoBehaviour
{
    [SerializeField]
    Image image;

    [SerializeField]
    Sprite free;

    [SerializeField]
    Sprite block;

    [SerializeField]
    TextMeshProUGUI textNumber;

    [SerializeField]
    int numberLevel = 0;

    [SerializeField]
    Button button;

    [SerializeField]
    LoadLevel loadLevel;

    void Start()
    {
        CheckThisButton();
    }

    public void CallButtonLevel()
    {  
        loadLevel.CallLevel(numberLevel);
    }

    private void CheckThisButton()
    {
        if (StatesGame.GetPhaseLevel(numberLevel-1))
        {
            image.sprite = free;
            textNumber.text = numberLevel.ToString();
            button.enabled = true;
        }
        else
        {
            image.sprite = block;
            textNumber.text = "";
            button.enabled = false;
        }
    }
}
