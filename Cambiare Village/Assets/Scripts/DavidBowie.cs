using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidBowie : MonoBehaviour
{
    public AudioSource sing;
    public GameObject music;
    public GameObject dialogue;

    public CoinTracker coinTrack;

    public void OnClick()
    {
        if (coinTrack.ReturnCoin() >= 6)
        {
            MoveToCenter();

            music.SetActive(false);
            sing.Play();
            music.SetActive(true);
            dialogue.SetActive(false);
        }

        else
        {
            dialogue.SetActive(true);
        }
    }

    public void MoveToCenter()
    {

    }
}
