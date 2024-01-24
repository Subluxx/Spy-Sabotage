using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    [SerializeField] private Transform fireSpawnPos;
    [SerializeField] private GameObject fireballPrefab;
    [SerializeField] private float timeInBetweenFireballs;
    private Timer timer;

    void Start()
    {
        timer = new Timer(timeInBetweenFireballs); // 100 is the length between each fire projectile
    }

    void Update()
    {
        timer.IncrementTimer();
        if (timer.CheckAndResetTimer()) // returns true if current time exceeds time specified above
        {
            GameObject fireball = Instantiate(fireballPrefab, fireSpawnPos.position, fireSpawnPos.rotation);
        }
    }
}
