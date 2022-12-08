using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerRotate : MonoBehaviour
{
    public GameObject windingKey;
    public GameObject WK;
    public UnityEvent eventRotate;
    public UnityEvent drawerOpen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Destroy(windingKey);
            WK.SetActive(true);
            eventRotate.Invoke();
            StartCoroutine("box");
        }
    }

    IEnumerator box()
    {
        yield return new WaitForSeconds(6);
        drawerOpen.Invoke();
    }
}
