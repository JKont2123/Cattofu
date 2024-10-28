using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    public bool shooting = false;

    public int count;
    private int startingCount = 0;
    

    private void Start()
    {
        count = startingCount;
    }

    private void Update()
    {
        if (shooting)
        {
            if(count >= 3)
            {
                shooting = false;
            }
            else
            {
                count++;
            }
        }
    }

    private void OnTriggerStay (Collider other)
    {
        if(other.gameObject.CompareTag("Target")) 
        {
            if(shooting)
            {
                Destroy(other.gameObject);
                shooting = false;
            }
        }
    }
    public void Shoot()
    {
        shooting = true;
    }
    public void StopShooting()
    {
        count = startingCount;
    }

}
