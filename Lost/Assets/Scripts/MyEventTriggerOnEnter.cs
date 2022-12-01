using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyEventTriggerOnEnter : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent myEvents;
    public UnityEvent myEvents2;
    public UnityEvent jumpScare;

    public GameObject Scare;
    [SerializeField] private AudioSource audioSource;


    private void OnTriggerEnter(Collider other)
    {
        myEvents.Invoke();
        myEvents2.Invoke();
        StartCoroutine("Buffer");
        Scare.SetActive(true);
        jumpScare.Invoke();
        audioSource.Play();
    }

    IEnumerator Buffer()
    {
        yield return new WaitForSeconds(2f);
    }
}
