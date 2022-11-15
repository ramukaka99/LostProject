using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateLights : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject objectDeactivate;
    public bool hasPlayed = false;
    public GameObject cricketSound;
    public GameObject newCricketSound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !audioSource.isPlaying && !hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
            objectDeactivate.SetActive(false);
            Destroy(cricketSound);
            newCricketSound.SetActive(true);
        }
    }
}
