using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Subtitle : MonoBehaviour
{
    public AudioSource audioSource;
    //public GameObject uiObject;
    public GameObject dialogue;
    public bool hasPlayed = false;
    [SerializeField] private float duration;
    [SerializeField] int letterPerSeconds;
    [SerializeField] TextMeshProUGUI dialogText;
    [SerializeField] string Text;

    // Start is called before the first frame update
    void Start()
    {
        //uiObject.SetActive(false);
        dialogue.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !audioSource.isPlaying && !hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
            //uiObject.SetActive(true);
            dialogue.SetActive(true);
            //StartCoroutine(TypeDialog(Text));
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator TypeDialog(string dialog)
    {
        dialogText.text = "";
        foreach(var letter in dialog.ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(1f / letterPerSeconds);
        }
    }


    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(duration);
        Destroy(dialogue);
    }
}
