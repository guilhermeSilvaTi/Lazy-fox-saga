using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhiteScreen : MonoBehaviour
{
    [SerializeField]
    Image loadBlue;

    [SerializeField]
    Vector2 positionBeggin = new Vector2(1.302409f, -24.9f);

    [SerializeField]
    GameObject windowsWhite;

    void Start()
    {
        windowsWhite.transform.position = positionBeggin;
        loadBlue.fillAmount = 1;
        loadBlue.CrossFadeAlpha(0f, 1.5f, false);
        StartCoroutine(GoToFarWay());
    }

    private IEnumerator GoToFarWay()
    {
        yield return new WaitForSeconds(1.5f);
        windowsWhite.transform.position = new Vector2(-86.3f,18f);
    }
   
}
