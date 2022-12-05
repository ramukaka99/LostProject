using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class countdownScene4 : MonoBehaviour
{
    public float timer = 17f;
    public Image black;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene(8);
        }
    }
}
