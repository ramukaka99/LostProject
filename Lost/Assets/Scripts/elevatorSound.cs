using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorSound : MonoBehaviour
{
    public AudioSource button;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Player"))
        {
            button.Play();
        }
    }
}
