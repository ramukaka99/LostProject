using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MyEventTriggerOnEnter : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent myEvents;
    public UnityEvent myEvents2;
    public UnityEvent jumpScare;

    public GameObject Scare;
    private bool audioPlayed = false;
    [SerializeField] private AudioSource audioSource;

    void Start()
    {
        Scare.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!audioSource.isPlaying && !audioPlayed)
        {
            Scare.SetActive(true);
            jumpScare.Invoke();
            audioSource.Play();
            audioPlayed = true;
            StartCoroutine("Buffer");
        }
    }

    IEnumerator Buffer()
    {
        yield return new WaitForSeconds(5f);
        myEvents.Invoke();
        myEvents2.Invoke();
        //SceneManager.LoadScene(8);
    }
}
