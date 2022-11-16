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

    public GameObject dialogue;
    [SerializeField] private float duration;

    void Start()
    {
        dialogue.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !audioSource.isPlaying && !hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
            objectDeactivate.SetActive(false);
            dialogue.SetActive(true);
            StartCoroutine("WaitForSec");
            Destroy(cricketSound);
            newCricketSound.SetActive(true);
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(duration);
        Destroy(dialogue);
    }
}
