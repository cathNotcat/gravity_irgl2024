using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NormalCoin : MonoBehaviour
{
    public Text CoinText;
    public static int addCoin = 0;

    void Start()
    {
        addCoin = 0;
    }

    void Update()
    {
        CoinText.text = "COINS : " + addCoin.ToString();
    }
    public void MenuButton()
    {
        PlayerPrefs.SetInt("MostCoins", addCoin);

        if (addCoin > PlayerPrefs.GetInt("MostCoins"))
        {
            PlayerPrefs.SetInt("MostCoins", addCoin);
        }
        
        SceneManager.LoadScene(1);
    }
}
