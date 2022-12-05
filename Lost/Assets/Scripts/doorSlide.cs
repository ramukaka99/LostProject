using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class doorSlide : MonoBehaviour
{
    public AudioSource audioSource;
    public bool hasPlayed = false;

    [Header("Custom Event")]
    public UnityEvent myEvents;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !audioSource.isPlaying && !hasPlayed)
        {
            myEvents.Invoke();
            audioSource.Play();
            hasPlayed = true;
        }
    }
}
