using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void teddyBear()
    {
        SceneManager.LoadScene(2);
    }

    public void DemoChange()
    {
        SceneManager.LoadScene(0);
    }
}
