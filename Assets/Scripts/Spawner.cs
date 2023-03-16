using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnRepeat;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", 2);
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(obstacle, transform.position, transform.rotation * Quaternion.Euler(0f, -90f, 0f));
        spawnRepeat = Random.Range(2, 7);
        Invoke("Spawn", spawnRepeat);
    }
}
