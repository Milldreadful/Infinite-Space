using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameManager gm;
    public GameObject effect;

    public Animator spin;
    public Animator score;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectable")
        {
            Instantiate(effect, transform.position, transform.rotation);
            spin.SetTrigger("Collect");
            Destroy(other.gameObject);
            score.SetTrigger("Score");
            gm.AddScore();
        }
    }
}
