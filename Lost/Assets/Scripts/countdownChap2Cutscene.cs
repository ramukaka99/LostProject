using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class countdownChap2Cutscene : MonoBehaviour
{
    public float timer = 7f;
    public Image black;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene(10);
        }
    }
}
