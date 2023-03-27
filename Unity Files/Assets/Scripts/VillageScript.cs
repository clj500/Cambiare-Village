using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageScript : MonoBehaviour
{
    public GameObject musicUI;

    public GameObject PauseMenuScreen;
    public static bool isPaused;

    public AudioSource buttonClick;

    // Start is called before the first frame update
    void Start()
    {
        //       Cursor.visible = false;
        //        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
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
