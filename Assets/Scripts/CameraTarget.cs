using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{

    public Transform target;
    public float cameraSpeed;

    public Camera[] cameras;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, cameraSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            DisableCameras();
            cameras[0].enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            DisableCameras();
            cameras[1].enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            DisableCameras();
            cameras[2].enabled = true;
        }
    }

    public void DisableCameras()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].enabled = false;
        }
    }
}
