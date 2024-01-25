using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    Vector2 movement;
    public Transform SpawnPos;

    void Update()
    {
        if (gameObject.CompareTag("Player1"))
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
        else if (gameObject.CompareTag("Player2"))
        {
            movement.x = Input.GetAxisRaw("Horizontal2");
            movement.y = Input.GetAxisRaw("Vertical2");
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Trap"))
        {
            transform.position = SpawnPos.position;
        }
    }
}

