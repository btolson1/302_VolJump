/* 
Brien, Brycen, Robert, Kush
Vol Jump Project
5/8/2023
Platform Physics
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    //Pre initialized jump force
    public float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            // Camera updates its position after each bounce
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            Camera.main.GetComponent<CameraFollow>().UpdateCamera();
            if (rb != null)
            {
                // Platforms are destroyed on contact
                Destroy(gameObject);
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;

            }

        }

    }
    
}
