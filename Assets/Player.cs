﻿using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 forceToApply;
    public float moveSpeed;
    public float forceDamping;
    public Rigidbody2D rb;
    Animator anim;

    private bool isMoving;

    public Transform SpawnPos;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (rb.velocity.magnitude < 0.01)
        {
           anim.speed = 0.0f;
        }
        else
        {
            anim.speed = 1.0f;
        }

        Vector2 playerInput = new Vector2();

        // normalizes the player input vector, makes diagonal movement not as fast
        if (gameObject.CompareTag("Player1")) playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        if (gameObject.CompareTag("Player2")) playerInput = new Vector2(Input.GetAxisRaw("Horizontal2"), Input.GetAxisRaw("Vertical2")).normalized;

        // the move force vector is multiplied by the specified speed
        Vector2 moveForce = playerInput * moveSpeed;

        // below prevents any movement jitter and smoothens out everything
        moveForce += forceToApply;
        forceToApply /= forceDamping;
        if (Mathf.Abs(forceToApply.x) <= 0.01f && Mathf.Abs(forceToApply.y) <= 0.01f) forceToApply = Vector2.zero;

        // finalises changes to rigidbody
        rb.velocity = moveForce;

        // if the player is moving
        if (rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            // set the float values that handle player movement to the current player velocity
            anim.SetFloat("xspeed", rb.velocity.x);
            anim.SetFloat("yspeed", rb.velocity.y);

            if (!isMoving) isMoving = true;
        }
        else
        {
            if (isMoving) isMoving = false;
        }

        anim.SetBool("isMoving", isMoving);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.collider.CompareTag("Trap"))
        {
            transform.position = SpawnPos.position;
        }
    }
}
