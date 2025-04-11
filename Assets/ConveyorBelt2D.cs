using UnityEngine;

public class ConveyorBelt2D : MonoBehaviour
{
    public float speed = 2f; // Kecepatan conveyor belt

    private void OnCollisionStay2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.rigidbody;
        if (rb != null)
        {
            // Gerakkan sampah ke atas
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, speed);
           
        }
    }
}
