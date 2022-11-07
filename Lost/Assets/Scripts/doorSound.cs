using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorSound : MonoBehaviour
{
    public AudioSource audioSource;
    public bool hasPlayed = false;
    public GameObject Vase;
    public GameObject BrokeVase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !audioSource.isPlaying && !hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;

            Destroy(Vase);
            Instantiate(BrokeVase, new Vector3(-30, 0, -17), Quaternion.identity);
        }
    }
}
