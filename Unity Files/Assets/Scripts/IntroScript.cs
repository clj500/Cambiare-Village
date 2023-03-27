using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScript : MonoBehaviour
{
    public GameObject currentPageUI;
    public GameObject nextPageUI;
    public GameObject musicUI;

    public GameObject PauseMenuScreen;
    public static bool isPaused;

    public AudioSource buttonClick;

    void Start()
    {
        //       Cursor.visible = false;
        //        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (nextPageUI.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }

        else
        {
            //           Cursor.visible = false;
            //          Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void nextPage()
    {
        buttonClick.Play();
        nextPageUI.SetActive(true);
        currentPageUI.SetActive(false);
    }

    public void Pause()
    {
        PauseMenuScreen.SetActive(true);
        musicUI.SetActive(false);
        isPaused = true;
    }

    public void Resume()
    {
        buttonClick.Play();
        PauseMenuScreen.SetActive(false);
        musicUI.SetActive(true);
        isPaused = false;
    }
}
