using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text HSText;
    void Start()
    {
        HSText.text = "High Score : " + PlayerPrefs.GetInt("HighScore");
    }
}
