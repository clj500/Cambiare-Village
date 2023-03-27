using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestMaster : MonoBehaviour
{
    public GameObject QuestScene;

    public AudioSource charClick;
    public AudioSource charGreet;
    public AudioSource charBye;

    public GameObject QuestPrompt1;
    public GameObject PlayerPrompt1;

    public GameObject QuestPrompt2;
    public GameObject PlayerPrompt2;

    public GameObject QuestPrompt3;
    public GameObject PlayerPrompt3;

    void Start()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (QuestScene.activeInHierarchy)
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

    public void OpenQuestScene()
    {
        charClick.Play();
        charGreet.Play();
        QuestScene.SetActive(true);

        SetQuestPrompt();
    }

    public void CloseQuestScene()
    {
        charBye.Play();
        QuestScene.SetActive(false);
    }

    public void SetQuestPrompt()
    {
        QuestPrompt1.SetActive(true);
        PlayerPrompt1.SetActive(true);
    }

    public void ChangeQuestPrompt1()
    {
        QuestPrompt1.SetActive(false);
        PlayerPrompt1.SetActive(false);

        QuestPrompt2.SetActive(true);
        PlayerPrompt2.SetActive(true);
    }

    public void ChangeQuestPrompt2()
    {
        QuestPrompt1.SetActive(false);
        PlayerPrompt1.SetActive(false);

        QuestPrompt2.SetActive(false);
        PlayerPrompt2.SetActive(false);

        QuestPrompt3.SetActive(true);
        PlayerPrompt3.SetActive(true);
    }
}
