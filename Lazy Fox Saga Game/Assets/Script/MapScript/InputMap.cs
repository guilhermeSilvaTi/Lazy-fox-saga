using System.Collections;
using System.Collections.Generic;
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

        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                //save began touch 2d point
                firstPressPos = new Vector2(t.position.x, t.position.y);
            }
            if (t.phase == TouchPhase.Ended)
            {
                //save ended touch 2d point
                secondPressPos = new Vector2(t.position.x, t.position.y);

                //create vector from the two points
                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

                //normalize the 2d vector
                currentSwipe.Normalize();

                //swipe upwards
                // if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)

                //swipe down
                // if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)

                //swipe left
                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                   mapLevel.LeftController();

                //swipe right
                if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                    mapLevel.RightController();

            }
        }
    }
}
