using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject pause;
    public GameObject inGame;

    // private int score = NormalCoin.addCoin;

    [SerializeField] ResultUIManager resultUIManagerScript;
    void Start()
    {
        gameOver.SetActive(false);
        pause.SetActive(false);
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        TriggerGameLose();
        // Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0;
    }
    public void Play()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToStart()
    {
        SceneManager.LoadScene(1);
    }
    public void StartButton()
    {
        SceneManager.LoadScene(2);
    }
    public void Exit()
    {
        Application.Quit();
        PlayerPrefs.DeleteAll();
    }

    public void TriggerGameLose()
    {
        int score = NormalCoin.addCoin;
        resultUIManagerScript.IsGameWin = false;
        resultUIManagerScript.GameScore = score;
        resultUIManagerScript.ShowSubmittingUI();
        // Time.timeScale = 0;
        Debug.Log("lose: " + score.ToString());
    }

    public void TriggerGameWin()
    {
        int score = NormalCoin.addCoin;
        resultUIManagerScript.IsGameWin = true;
        resultUIManagerScript.GameScore = score;
        resultUIManagerScript.ShowSubmittingUI();
        // Time.timeScale = 0;
        Debug.Log("win: " + score.ToString());
    }
}
