using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject retryButton;
    public GameObject quitButton;
    public GameObject effect;

    public Animator shakeAnim;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            retryButton.SetActive(true);
            quitButton.SetActive(true);
            Instantiate(effect, transform.position, transform.rotation);
            shakeAnim.SetTrigger("Shake");
            Destroy(gameObject);
        }
    }
}
