using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subtitle : MonoBehaviour
{
    public AudioSource audioSource;
    //public GameObject uiObject;
    public GameObject dialogue;
    public bool hasPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        //uiObject.SetActive(false);
        dialogue.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !audioSource.isPlaying && !hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
            //uiObject.SetActive(true);
            dialogue.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(dialogue);
    }
}
