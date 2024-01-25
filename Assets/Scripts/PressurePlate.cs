using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] List<GameObject> traps = new List<GameObject>();  //Array of Traps
    [SerializeField] GameObject boulder;
    [SerializeField] Sprite pressurePlateOff;
    [SerializeField] Sprite pressurePlateOn;
    [SerializeField] SpriteRenderer pressurePlateRenderer;
    private bool collided = false;
    public float activeTime;
    private Timer timer;

    private void Start()
    {
        timer = new Timer(activeTime + 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collided = true;
        boulder.SetActive(true);
        foreach (GameObject trap in traps) //Make each trap active for a set amount of time
        {
            trap.GetComponent<SpikeTrap>().playAnimation(activeTime);
        }
    }

    private void Update()
    {
        if(collided)
        {
            pressurePlateRenderer.sprite = pressurePlateOn;
            timer.IncrementTimer();
            if (timer.CheckAndResetTimer())
            {
                pressurePlateRenderer.sprite = pressurePlateOff;
                collided=false;
            }
        }
    }
}
