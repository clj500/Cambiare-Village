using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public AudioSource coinObtained;

    public GameObject coin;
    public bool hasCoin = false;

    public CoinTracker coinTrack;

    public PlayerExpressions playerExpression;

    private void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.tag == "Player")
        {
            GiveCoin();
            Destroy(gameObject);
        }
   }

    public void GiveCoin()
    {
        if (hasCoin == false)
        {
            coinObtained.Play();
            playerExpression.setPlayerSurprised();
            coin.SetActive(true);
            hasCoin = true;

            coinTrack.UpdateCoin();
        }

        else if (hasCoin == true)
        {
            coinTrack.UpdateCoin();
        }
    }
}
