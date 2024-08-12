using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddCoin : MonoBehaviour
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

        if (addCoin > PlayerPrefs.GetInt("EndlessCoins"))
        {
            PlayerPrefs.SetInt("EndlessCoins", addCoin);
        }
        
        SceneManager.LoadScene(5);
    }
}
