using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D playerRigdbody2D;

    [SerializeField]
    Vector2 velocityDeafault;

   private bool isTouchGround;

    public void StopPlayer()
    {
        playerRigdbody2D.velocity = Vector2.zero;
        playerRigdbody2D.bodyType = RigidbodyType2D.Static;
    }
    public void NewPositionPlayer(Vector2 valuePosition)
    {
        transform.position = valuePosition;
    }
    public void GravityStop()
    {
        if(isTouchGround)
         playerRigdbody2D.velocity = Vector2.zero; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isTouchGround = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isTouchGround = false;
    }
}
