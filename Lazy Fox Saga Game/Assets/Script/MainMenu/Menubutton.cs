using UnityEngine;

public class Menubutton : MonoBehaviour
{
    [SerializeField]
    GameObject currentGroupScreen;

    [SerializeField]
    GameObject newGroupScreen;

   public void TradeScreenGroup()
    {
        currentGroupScreen.SetActive(false);
        newGroupScreen.SetActive(true);

    }
}
