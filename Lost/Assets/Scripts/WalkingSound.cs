using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSound : MonoBehaviour
{
    CharacterController cc;
    public AudioSource audioSource;
    public bool hasPlayed = false;


    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded && cc.velocity.magnitude > 2f && !audioSource.isPlaying)
        {
            audioSource.Play();
            hasPlayed = true;
        }
    }
}
