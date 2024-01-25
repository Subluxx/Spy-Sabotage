using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraScript : MonoBehaviour
{
    public Transform assignedPlayer;
    private void LateUpdate() // Track Player's Transform position and follow it
    {
        Vector3 newPos = new Vector3(assignedPlayer.position.x, assignedPlayer.position.y, -10);
        transform.position = newPos;
    }
}