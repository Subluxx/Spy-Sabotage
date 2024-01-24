using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpikeTrap : MonoBehaviour
{
    public Animator spikeAnim;
    public bool activated = false;
    public void playAnimation(float duration)
    {
        StartCoroutine(PressurePlateTriggered(duration));
    }

    public IEnumerator PressurePlateTriggered(float duration)
    {
        if (activated == false)
        {
            activated = true;
            spikeAnim.SetBool("IsClosedTrap", false);
            spikeAnim.SetBool("IsOpeningTrap", true);
            yield return new WaitForSeconds(.3f);
            spikeAnim.SetBool("IsOpeningTrap", false);
            spikeAnim.SetBool("IsOpenedTrap", true);
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            yield return new WaitForSeconds(duration);
            spikeAnim.SetBool("IsOpenedTrap", false);
            spikeAnim.SetBool("IsClosingTrap", true);
            yield return new WaitForSeconds(.3f);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            spikeAnim.SetBool("IsClosingTrap", false);
            spikeAnim.SetBool("IsClosedTrap", true);
            activated = false;
        }
    }
}
