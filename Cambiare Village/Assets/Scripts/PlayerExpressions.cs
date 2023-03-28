using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExpressions : MonoBehaviour
{
    public GameObject neutral;
    public GameObject happy;
    public GameObject surprised;

    public void setPlayerNeutral()
    {
        neutral.SetActive(true);
        happy.SetActive(false);
        surprised.SetActive(false);
    }

    public void setPlayerHappy()
    {
        neutral.SetActive(false);
        happy.SetActive(true);
        surprised.SetActive(false);
    }

    public void setPlayerSurprised()
    {
        neutral.SetActive(false);
        happy.SetActive(false);
        surprised.SetActive(true);
    }
}
