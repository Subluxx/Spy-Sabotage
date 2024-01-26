using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Transform exit;
    private Transform playerTeleport;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private Animator anim;

    private void Start()
    {
        anim.SetBool("DoorClosed", true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            player1.GetComponent<Player>().SetCanMove(false);
        }
        if (collision.CompareTag("Player2"))
        {
            player2.GetComponent<Player>().SetCanMove(false);
        }

        StartCoroutine(DoorTeleportDelay(collision));
    }

    private IEnumerator DoorTeleportDelay(Collider2D collision)
    {
        anim.SetBool("DoorClosed", false);
        anim.SetBool("DoorClosing", false);
        anim.SetBool("DoorOpen", true);
        yield return new WaitForSeconds(0.71428571428f);
        anim.SetBool("DoorOpen", false);
        anim.SetBool("DoorClosing", true);
        yield return new WaitForSeconds(0.71428571428f);
        playerTeleport = collision.gameObject.transform;
        playerTeleport.position = exit.position;
        player1.GetComponent<Player>().SetCanMove(true);
        player2.GetComponent<Player>().SetCanMove(true);
        anim.SetBool("DoorOpen", false);
        anim.SetBool("DoorClosing", false);
        anim.SetBool("DoorClosed", true);
    }
}
