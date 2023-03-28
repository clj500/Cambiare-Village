using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest1Script : MonoBehaviour
{
    public GameObject PauseMenuScreen;
    public static bool isPaused;

    public AudioSource buttonClick;

    // Start is called before the first frame update
    void Start()
    {
        
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
        isPaused = true;
    }

    public void Resume()
    {
        buttonClick.Play();
        PauseMenuScreen.SetActive(false);
        isPaused = false;
    }
}
