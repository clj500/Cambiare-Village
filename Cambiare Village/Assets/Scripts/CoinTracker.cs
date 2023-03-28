using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinTracker : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    public int coinNum;

    public bool add = true;

    public void UpdateCoin()
    {
        if (add == true)
        {
            coinNum += 1;
        }

        else if (add == false)
        {
            coinNum -= 1;
            add = true;
        }

        coinText.text = coinNum.ToString();
    }

    public int ReturnCoin()
    {
        return coinNum;
    }
}
