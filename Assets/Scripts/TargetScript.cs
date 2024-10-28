using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float spawnRate = 2;
    private float timer = 0;
    private void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
            timer = 0;
        }
    }
}
