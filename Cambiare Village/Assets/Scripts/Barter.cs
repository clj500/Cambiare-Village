using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barter : MonoBehaviour
{
    public GameObject BarterScene;

    public AudioSource charClick;
    public AudioSource charGreet;
    public AudioSource charBye;

    public GameObject BarterPrompt1;
    public GameObject PlayerPrompt1;

    public GameObject BarterPrompt2;
    public GameObject PlayerPrompt2;

    public GameObject BarterPrompt3;

    void Start()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (BarterScene.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        else
        {
            //Cursor.visible = false;
            //Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void OpenBarterScene()
    {
        charClick.Play();
        charGreet.Play();
        BarterScene.SetActive(true);
    }

    public void CloseBarterScene()
    {
        charBye.Play();
        BarterScene.SetActive(false);
    }

    public void SetBarterPrompt()
    {
        BarterPrompt1.SetActive(true);
        PlayerPrompt1.SetActive(true);

        BarterPrompt2.SetActive(false);
        PlayerPrompt2.SetActive(false);

        BarterPrompt3.SetActive(false);
    }

    public void ChangeBarterPrompt1()
    {
        BarterPrompt1.SetActive(false);
        PlayerPrompt1.SetActive(false);

        BarterPrompt2.SetActive(true);
        PlayerPrompt2.SetActive(true);

        BarterPrompt3.SetActive(false);
    }

    public void ChangeBarterPrompt2()
    {
        BarterPrompt1.SetActive(false);
        PlayerPrompt1.SetActive(false);

        BarterPrompt2.SetActive(false);

        BarterPrompt3.SetActive(true);
        PlayerPrompt2.SetActive(true);
    }
}
