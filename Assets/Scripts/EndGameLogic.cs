using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameLogic : MonoBehaviour
{
    public GameObject endgame;

    public void HandleEndGame()
    {
        endgame.transform.gameObject.SetActive(true);
    }
}
