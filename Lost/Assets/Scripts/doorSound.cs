using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class doorSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public bool hasPlayed = false;
    public GameObject Vase;
    public GameObject BrokeVase;
    public Transform trans;

    public UnityEvent Instruction;

    public GameObject dialogue;
    [SerializeField] private float duration;

    void Start()
    {
        dialogue.SetActive(false);
    }

    public void destroyobject()
    {
            Destroy(Vase);
            new WaitForSeconds(4f);
            audioSource2.Play();
            Instantiate(BrokeVase, trans.position, Quaternion.identity);
            Instruction.Invoke();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !audioSource.isPlaying && !hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
            dialogue.SetActive(true);
            StartCoroutine("WaitForSec");
            destroyobject();
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(duration);
        Destroy(dialogue);
    }
}
