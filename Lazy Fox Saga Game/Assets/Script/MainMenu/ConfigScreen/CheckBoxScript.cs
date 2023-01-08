using UnityEngine.UI;
using UnityEngine;
using System;

public class CheckBoxScript : MonoBehaviour
{
    [SerializeField]
    Toggle touchScreen;
    [SerializeField]
    Toggle gyroscope;

    void Start()
    {
        CheckStatesPlayer();
    }

    private void CheckStatesPlayer()
    {
        if (!StatesGame.GetIsGyroscope())
        {
            touchScreen.isOn = true;
            gyroscope.isOn = false;
        }
        else
        {
            gyroscope.isOn = true;
            touchScreen.isOn = false;
        }
    }

    public void TraDeStatesToTouch(Toggle toggle)
    {
        StatesGame.SetIsGyroscope(false);     
    }
    public void TraDeStatesToGyroscope(Toggle toggle)
    {   
        StatesGame.SetIsGyroscope(true);
    }
}
