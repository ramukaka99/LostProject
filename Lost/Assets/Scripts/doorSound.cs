using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public bool hasPlayed = false;
    public GameObject Vase;
    public GameObject BrokeVase;
    public Transform trans;

    public void destroyobject()
    {
            Destroy(Vase);
            new WaitForSeconds(4f);
            audioSource2.Play();
            Instantiate(BrokeVase, trans.position, Quaternion.identity);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !audioSource.isPlaying && !hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
            destroyobject();
        }
    }
}
