using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float direction; //Deciding which direction the boulder moves - needs to be 1 or -1
    [SerializeField] Transform spawn;
    Vector2 force = new Vector2(3f, 0f);

    private void Awake()
    {
        force.x = force.x * direction;
    }

    void Update()
    {
        rb.AddForce(force); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.transform.position = spawn.position;
        gameObject.SetActive(false);
    }
}
