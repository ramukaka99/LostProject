using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class fifthFloorLift : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent myEvents;
    public UnityEvent myEvents2;


    private void OnTriggerEnter(Collider other)
    {
        myEvents.Invoke();
        myEvents2.Invoke();
        StartCoroutine("Buffer");
    }
    IEnumerator Buffer()
    {
        yield return new WaitForSeconds(1f);
        myEvents.Invoke();
        myEvents2.Invoke();
        SceneManager.LoadScene(11);
    }
}
