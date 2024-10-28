using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject raycast;
    // Start is called before the first frame update
    void Start()
    {
        raycast.SetActive(false);
    }

    public void GunPickedUp()
    {
        raycast.SetActive(true);
    }

    public void GunDropped()
    {
        raycast.SetActive(false);
    }
}
