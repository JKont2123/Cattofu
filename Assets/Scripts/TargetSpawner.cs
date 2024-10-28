using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject target;
    private GameObject targetSpawner;

    private float timer;

    private void Start()
    {
        targetSpawner = GetComponent<GameObject>();
        timer = Random.Range(3.0f, 8.0f);
    }

    private void Update()
    {
        if(timer > 0)
        {
            timer = timer - Time.deltaTime;
        }
        else
        {
            spawnTarget();
            timer = Random.Range(3.0f,15.0f);
        }

        
    }

    void spawnTarget() 
    {
            Instantiate(target, transform.position, transform.rotation);
    }
}
