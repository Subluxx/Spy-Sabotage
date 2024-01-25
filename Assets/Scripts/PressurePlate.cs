using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] List<GameObject> traps = new List<GameObject>();  //Array of Traps
    public float activeTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (GameObject trap in traps) //Make each trap active for a set amount of time
        {
            trap.GetComponent<SpikeTrap>().playAnimation(activeTime);
        }
    }
}
