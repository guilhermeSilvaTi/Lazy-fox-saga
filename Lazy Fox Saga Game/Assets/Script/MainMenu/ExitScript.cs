
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    void Update()
    {
        CheckInput();
    }
    private void CheckInput()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
