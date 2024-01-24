using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    Animator anim;

    Vector2 movement;
    public Transform SpawnPos;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        anim.SetFloat("xspeed", rb.velocity.x);
        anim.SetFloat("yspeed", rb.velocity.y);
        if (rb.velocity.magnitude < 0.01)
        {
           anim.speed = 0.0f;
        }
        else
        {
            anim.speed = 1.0f;
        }

        if (gameObject.CompareTag("Player1"))
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;
        }
        else if (gameObject.CompareTag("Player2"))
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2")) * moveSpeed;
        }

        Debug.Log("Velocity: " + rb.velocity);
        Debug.Log("Anim Speed " + anim.speed);
    }

    void FixedUpdate()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.collider.CompareTag("Trap"))
        {
            transform.position = SpawnPos.position;
        }
    }
}

