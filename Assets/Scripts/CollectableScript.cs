using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    public GameObject collectable;
    public float spawnRepeat;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("CollectableSpawn", 2);
    }

        // Update is called once per frame
        void CollectableSpawn()
        {
            Instantiate(collectable, transform.position, transform.rotation * Quaternion.Euler(0f, 90f, -80f));
            spawnRepeat = Random.Range(2, 6);
            Invoke("CollectableSpawn", spawnRepeat);
        }
    }

