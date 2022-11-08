using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorSound : MonoBehaviour
{
    public AudioSource audioSource;
    public bool hasPlayed = false;
    public GameObject Vase;
    public GameObject BrokeVase;
    public Transform trans;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player" && !audioSource.isPlaying && !hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;

            Destroy(Vase);
            Instantiate(BrokeVase, trans.position, Quaternion.identity);
        }
    }
}
