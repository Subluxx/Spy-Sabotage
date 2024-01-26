using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour
{

    public Transform canvas;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canvas.transform.gameObject.SetActive(true);
    }

}
