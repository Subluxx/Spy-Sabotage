using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player1")) EndGameLogic.HandleEndGame(true);
        if (collision.collider.CompareTag("Player2")) EndGameLogic.HandleEndGame(false);
    }

}
