using UnityEngine.EventSystems;
using UnityEngine;

public class BackgroundRotation : MonoBehaviour
{
    [SerializeField]
    float velocity = 10;

    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    AudioSource moveSound;

    private float width;

    [SerializeField]
    Player player;

    private void Start()
    {
        width = Screen.width * 0.5f;
    }

    void Update()
    {
        if (gameManager.GetIsActiveGame())
        {
            InputKeyboard();
            TouchScreen();
        }
    }

    private void TouchScreen()
    {
        Vector2 comparationPosition = Input.mousePosition; //Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (EventSystem.current.currentSelectedGameObject == null)
        {
            if (Input.GetMouseButton(0))
            {
                player.GravityStop();
                if (width > comparationPosition.x)
                {
                    RotationToDirection(velocity);
                }
                if (width < comparationPosition.x)
                {
                    RotationToDirection(-velocity);
                }
            }
        }
    }

    private void InputKeyboard()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotationToDirection(velocity);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotationToDirection(-velocity);
        }
    }

    private void RotationToDirection(float getVelocity)
    {
        transform.Rotate(0, 0, getVelocity * Time.deltaTime);
        moveSound.Play();
    }
}
