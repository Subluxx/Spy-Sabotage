using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject trap;
    bool activated = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(PressurePlateTriggered());
    }
    public IEnumerator PressurePlateTriggered()
    {
        if (activated == false)
        {
            trap.SetActive(true);
            activated = true;
            yield return new WaitForSeconds(3f);
            trap.SetActive(false);
            activated = false;

        }
    }
}
