using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NormalScore : MonoBehaviour
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
}
