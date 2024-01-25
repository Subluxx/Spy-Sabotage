using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    Vector2 force = new Vector2(3f, 0f);

    void Update()
    {
        rb.AddForce(force); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }
}
