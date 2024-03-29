 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraScript : MonoBehaviour
{
    public Transform assignedPlayer;
    bool reachedPlayer = false;
    float cameraSpeed = 1f;
    [SerializeField] private GameObject playerScriptHandler;

    private void Start()
    {
        playerScriptHandler.GetComponent<Player>().SetCanMove(false);
    }
    private void Update()
    {
      
    }
    private void LateUpdate()
    {
        if (reachedPlayer) 
        {
            Vector3 newPos = new Vector3(assignedPlayer.position.x, assignedPlayer.position.y, -10);
            transform.position = newPos;
        }
        else if (!reachedPlayer)
        {
            float interpolation = cameraSpeed * Time.deltaTime;

            Vector3 position = this.transform.position;
            position.y = Mathf.Lerp(this.transform.position.y, assignedPlayer.transform.position.y, interpolation);
            position.x = Mathf.Lerp(this.transform.position.x, assignedPlayer.transform.position.x, interpolation);

            this.transform.position = position;

            if (position.x >= assignedPlayer.transform.position.x - .2 && position.x <= assignedPlayer.transform.position.x + .2)
            {
                reachedPlayer = true;
                playerScriptHandler.GetComponent<Player>().SetCanMove(true);
            }
        }
    }
}