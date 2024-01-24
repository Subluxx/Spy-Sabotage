using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraScript : MonoBehaviour
{
    public Transform assignedPlayer;
    private void LateUpdate()
    {
        Vector3 newPos = new Vector3(assignedPlayer.position.x, transform.position.y, -10);
        transform.position = newPos;
    }
}