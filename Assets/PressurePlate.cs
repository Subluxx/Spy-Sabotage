using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject SpikeTrap;
    bool activated = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(PressurePlateTriggered());
    }
    public IEnumerator PressurePlateTriggered()
    {
        if (activated == false)
        {
            //SpikeTrap.spike = true;
            activated = true;
            yield return new WaitForSeconds(10f);
            activated = false;

        }
    }
}