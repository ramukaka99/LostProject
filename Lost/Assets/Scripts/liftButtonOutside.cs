using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class liftButtonOutside : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent myEvents;
    public UnityEvent myEvents2;


    private void OnTriggerEnter(Collider other)
    {
        myEvents.Invoke();
        myEvents2.Invoke();
    }
}
