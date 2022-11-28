using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryOn : MonoBehaviour
{
    [SerializeField] GameObject Flash;
    [SerializeField] GameObject Battery;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Flash.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key") && !audioSource.isPlaying)
        {
            audioSource.Play();
            Flash.SetActive(true);
            Destroy(Battery);
        }
    }


}
