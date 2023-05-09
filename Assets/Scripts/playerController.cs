/* 
Brien, Brycen, Robert, Kush
Vol Jump Project
5/8/2023
Player Physics
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    private float moveX;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Can Only change the characters left/right movement
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    // Pre-Initialize move speed of player to 10
    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }
}
