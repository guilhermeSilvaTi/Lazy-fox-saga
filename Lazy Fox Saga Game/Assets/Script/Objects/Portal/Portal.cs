
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    Transform outPortal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            collision.GetComponent<Player>().NewPositionPlayer(new Vector2(outPortal.position.x, outPortal.position.y));
    }
}
