using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameMenu : MonoBehaviour
{
    public GameObject WristUI;

    public bool activeWristUI = true;

    // Start is called before the first frame update
    void Start()
    {
        DisplayWristUI();
    }

    public void PauseButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
            DisplayWristUI();
    }

    public void DisplayWristUI()
    {
        if (activeWristUI)
        {
            WristUI.SetActive(false);
            activeWristUI = false;
        }
        else if (!activeWristUI)
        {
            WristUI.SetActive(true);
            activeWristUI = true;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
