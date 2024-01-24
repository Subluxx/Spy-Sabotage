using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, -100)); // sends the fireball down
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CollisionDelay());
        StopCoroutine(CollisionDelay());
    }

    private IEnumerator CollisionDelay() // allows the fireball to pass through the wall it spawns in
    {
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
