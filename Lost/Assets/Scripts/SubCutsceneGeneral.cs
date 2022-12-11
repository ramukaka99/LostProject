using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubCutsceneGeneral : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    [SerializeField] private float duration1;
    [SerializeField] private float duration2;

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
        yield return new WaitForSeconds(duration1);
        Destroy(dialogue1);

        dialogue2.SetActive(true);
        yield return new WaitForSeconds(duration2);
        Destroy(dialogue2);
    }
}
