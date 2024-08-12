using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NormalMostCoin : MonoBehaviour
{
    public Text HSText;
    void Start()
    {
        HSText.text = "Most Coins Taken : " + PlayerPrefs.GetInt("MostCoins");
    }
    public void MenuButton()
    {
        PlayerPrefs.SetInt("MostCoins", NormalCoin.addCoin);

        if (NormalCoin.addCoin > PlayerPrefs.GetInt("MostCoins"))
        {
            PlayerPrefs.SetInt("MostCoins", NormalCoin.addCoin);
        }

        SceneManager.LoadScene(0);
    }
}
