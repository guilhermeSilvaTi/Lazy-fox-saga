
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    AudioSource sound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(gameManager.EndGame());         
            sound.Play();
        }
    }
}
