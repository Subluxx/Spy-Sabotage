using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnimation : MonoBehaviour
{
    [SerializeField] GameObject bloodsplatter;
    private Timer timer;

    private void Start()
    {
        timer = new Timer(1.09f);
    }

    private void Update()
    {
        timer.IncrementTimer();
        if (timer.CheckAndResetTimer())
        {
            bloodsplatter.SetActive(false);
            Destroy(gameObject);
        }
    }
}
