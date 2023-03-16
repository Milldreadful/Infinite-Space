using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource myAudio;
    public float minVolume = 0.4f;
    public float maxVolume = 1;
    public float soundTransitionTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        myAudio.volume = minVolume;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            myAudio.volume = Mathf.Lerp(myAudio.volume, maxVolume, soundTransitionTime * Time.deltaTime);
        }

        else
        {
            myAudio.volume = minVolume;
        }
    }
}
