using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PotionTracker : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI potionText;
    public int potionNum;

    public bool add = true;

    public void UpdatePotion()
    {
        if (add == true)
        {
            potionNum += 1;
        }

        else if (add == false)
        {
            potionNum -= 1;
            add = true;
        }

        potionText.text = potionNum.ToString();
    }

    public int ReturnPotionNum()
    {
        return potionNum;
    }
}
