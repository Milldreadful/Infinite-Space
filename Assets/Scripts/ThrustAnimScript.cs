using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustAnimScript : MonoBehaviour
{

    public Animator boost;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            boost.SetTrigger("Boost");
        }
    }
}
