using UnityEngine.EventSystems;
using UnityEngine;

public class InputMap : MonoBehaviour
{
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector3 currentSwipe;

    [SerializeField]
    MapLevel mapLevel;

    void Update()
    {
        Swipe();
    }
    public void Swipe()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
            mapLevel.RightController();

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            mapLevel.LeftController();

        if (EventSystem.current.currentSelectedGameObject == null)
        {
            if (Input.touches.Length > 0)
            {
                Touch t = Input.GetTouch(0);
                if (t.phase == TouchPhase.Began)
                {
                    firstPressPos = new Vector2(t.position.x, t.position.y);
                }
                if (t.phase == TouchPhase.Ended)
                {
                    secondPressPos = new Vector2(t.position.x, t.position.y);

                    currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

                    currentSwipe.Normalize();
                  
                    if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                        mapLevel.LeftController();

                    if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                        mapLevel.RightController();

                }
            }
        }
    }
}
