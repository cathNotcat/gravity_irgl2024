using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public Text ScoreText;
    public static float addScore = 0;
    public static int score = 0;

    void Start()
    {
        addScore = 0;
    }
    void Update()
    {
        addScore += Time.deltaTime * 0.8f;
        score = (int)addScore;
        ScoreText.text = "SCORE : " + score.ToString();
    }
    public void MenuButton()
    {

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        
        SceneManager.LoadScene(5);
    }
}
