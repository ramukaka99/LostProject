using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMech : MonoBehaviour
{
    public GameObject lockBar;
    public GameObject key;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Key"))
        {
            Destroy(lockBar);
            Destroy(key);
            Debug.Log("Key to door");
        }
    }
}
