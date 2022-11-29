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
}
