using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorAreaScript : MonoBehaviour
{
    public GameObject[] spawner;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Rocket")
        {
            for (int i = 0; i < spawner.Length; i++)
            {
                spawner[i].SetActive(true);
            }
        }
    }
}
