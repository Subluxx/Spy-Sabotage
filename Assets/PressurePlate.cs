using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] List<GameObject> traps = new List<GameObject>();  
    public float activeTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (GameObject trap in traps)
        {
            trap.GetComponent<SpikeTrap>().playAnimation(activeTime);
            Debug.Log("Foreach Loop");
        }
    }
}
