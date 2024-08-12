using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostCoins : MonoBehaviour
{
    public Text HSText;
    void Start()
    {
        HSText.text = "Most Coins Taken : " + PlayerPrefs.GetInt("EndlessCoins");
    }
}
