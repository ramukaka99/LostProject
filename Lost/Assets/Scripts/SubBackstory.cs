using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubBackstory : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    [SerializeField] private float duration;

    // Start is called before the first frame update
    void Start()
    {
        dialogue1.SetActive(false);
        dialogue2.SetActive(false);
        StartCoroutine(playSubtitle());
    }

    IEnumerator playSubtitle()
    {
        dialogue1.SetActive(true);
        yield return new WaitForSeconds(2);
        Destroy(dialogue1);

        dialogue2.SetActive(true);
        yield return new WaitForSeconds(duration);
        Destroy(dialogue2);
    }
}
