using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float speed = 3f;
    public float timer;
    public float destroyTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        int dir = Random.Range(0, 2);

        if(dir == 00)
        {
            speed = -speed;
            transform.position = new Vector3(transform.position.x + 10, transform.position.y, transform.position.z);
        }

        else
        {
            speed = +speed;
            transform.position = new Vector3(transform.position.x - 10, transform.position.y, transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.position += Vector3.right * speed * Time.deltaTime;
       

        if (timer > destroyTime)
        {
            Destroy(gameObject);
            timer = 0f;
        }
    }
}
