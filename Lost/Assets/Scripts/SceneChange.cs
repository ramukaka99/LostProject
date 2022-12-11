using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void teddyBear()
    {
        SceneManager.LoadScene(3);
    }

    public void toyCar()
    {
        SceneManager.LoadScene(5);
    }

    public void DemoChange()
    {
        SceneManager.LoadScene(0);
    }

    public void presentbox()
    {
        SceneManager.LoadScene(9);
    }

    public void ring()
    {
        SceneManager.LoadScene(12);
    }

    public void brokenTeddyBear()
    {
        SceneManager.LoadScene(14);
    }

    public void portrait()
    {
        SceneManager.LoadScene(16);
    }

    public void car()
    {
        SceneManager.LoadScene(18);
    }
}
