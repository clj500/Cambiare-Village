using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidBowie : MonoBehaviour
{
    public AudioSource sing;

    public void Perform()
    {
        MoveToCenter();

        sing.Play();
    }

    public void MoveToCenter()
    {

    }
}
