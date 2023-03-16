using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Movement : MonoBehaviour
{
    public Rigidbody myRb;
    public float speed;
    public float originalSpeed;
    public float boost;

    // Start is called before the first frame update
    void Start()
    {
        originalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            speed = boost;
        }

        else if (Input.GetButton("Fire3"))
        {
            speed = -speed;
        }

        else
        {
            speed = originalSpeed;
        }

            transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
        
    }
}
