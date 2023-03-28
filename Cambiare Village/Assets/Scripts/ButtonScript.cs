using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public AudioSource buttonClick;

    public void LoadMainMenu()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadIntroScreen()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Introduction");
    }

    public void LoadVillageScreen()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Village");
    }

    public void LoadQuest1()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Quest1");
    }

    public void LoadControlsScreen()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Control Menu");
    }

    public void LoadSettingsScreen()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Settings Menu");
    }

    public void LoadCreditsScreen()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Credits");
    }

    public void ExitGame()
    {
        buttonClick.Play();
        Application.Quit();
    }
}
