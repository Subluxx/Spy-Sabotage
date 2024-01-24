using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    // generic timer class, can be used for anything

    private float timer;
    private float timeToExceed;

    public Timer(float timeToExceed)
    {
        timer = 0;
        this.timeToExceed = timeToExceed;
    }

    public void IncrementTimer()
    {
        timer += Time.deltaTime;
    }

    public bool CheckAndResetTimer()
    {
        if (timer > timeToExceed)
        {
            timer = 0;
            return true;
        }
        else return false;
    }
}
