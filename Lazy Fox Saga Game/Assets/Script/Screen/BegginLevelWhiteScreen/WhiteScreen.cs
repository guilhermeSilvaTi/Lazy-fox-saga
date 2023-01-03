using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhiteScreen : MonoBehaviour
{
    [SerializeField]
    Image loadBlue;


    void Start()
    {
        loadBlue.fillAmount = 1;
        loadBlue.CrossFadeAlpha(0f, 1.5f, false);
    }

   
}
