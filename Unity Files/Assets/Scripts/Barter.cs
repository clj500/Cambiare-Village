using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barter : MonoBehaviour
{
    public GameObject BarterScene;

    public AudioSource charClick;
    public AudioSource charGreet;
    public AudioSource charBye;

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
}
