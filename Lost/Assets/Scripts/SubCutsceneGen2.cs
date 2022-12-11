using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubCutsceneGen2 : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    public GameObject dialogue3;
    public GameObject dialogue4;
    [SerializeField] private float duration1;
    [SerializeField] private float duration2;
    [SerializeField] private float duration3;
    [SerializeField] private float duration4;

    // Start is called before the first frame update
    void Start()
    {
        dialogue1.SetActive(false);
        dialogue2.SetActive(false);
        dialogue3.SetActive(false);
        dialogue4.SetActive(false);
        StartCoroutine(playSubtitle());
    }

    IEnumerator playSubtitle()
    {
        dialogue1.SetActive(true);
        yield return new WaitForSeconds(duration1);
        Destroy(dialogue1);

        dialogue2.SetActive(true);
        yield return new WaitForSeconds(duration2);
        Destroy(dialogue2);

        dialogue3.SetActive(true);
        yield return new WaitForSeconds(duration3);
        Destroy(dialogue3);

        dialogue4.SetActive(true);
        yield return new WaitForSeconds(duration4);
        Destroy(dialogue4);
    }
}
