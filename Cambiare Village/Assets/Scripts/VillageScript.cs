using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageScript : MonoBehaviour
{
    public GameObject musicUI;

    public GameObject PauseMenuScreen;
    public static bool isPaused;

    public AudioSource buttonClick;
    public AudioSource potionObtained;
    public AudioSource bootsObtained;

    public GameObject Potion;
    public GameObject Boots;

    public bool hasPotion = false;
    public bool hasBoots = false;

    public CoinTracker coinTrack;
    public PotionTracker potionTrack;

    public Barter barter;

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

    public void GivePotion()
    {
        if (hasPotion == false && coinTrack.ReturnCoin() >= 1)
        {
            potionObtained.Play();
            Potion.SetActive(true);
            hasPotion = true;

            potionTrack.UpdatePotion();

            coinTrack.add = false;
            coinTrack.UpdateCoin();
        }

        else if (hasPotion == false && coinTrack.ReturnCoin() < 1)
        {
            barter.ChangeBarterPrompt1();    
        }

        else if (hasPotion == true && coinTrack.ReturnCoin() >= 1)
        {
            potionObtained.Play();

            potionTrack.UpdatePotion();

            coinTrack.add = false;
            coinTrack.UpdateCoin();
        }

        else if (hasPotion == true && coinTrack.ReturnCoin() < 1)
        {
            barter.ChangeBarterPrompt2();
        }
    }

    public void GiveBoots()
    {
        if (hasBoots == false && coinTrack.ReturnCoin() >= 4)
        {
            bootsObtained.Play();
            Boots.SetActive(true);
            hasBoots = true;

            coinTrack.add = false;
            coinTrack.UpdateCoin();
            coinTrack.add = false;
            coinTrack.UpdateCoin();
            coinTrack.add = false;
            coinTrack.UpdateCoin();
            coinTrack.add = false;
            coinTrack.UpdateCoin();
        }

        else if (hasBoots == false && coinTrack.ReturnCoin() < 4)
        {
            barter.ChangeBarterPrompt1();
        }

        else if (hasBoots == true)
        {
            barter.ChangeBarterPrompt2();
        }
    }
}
