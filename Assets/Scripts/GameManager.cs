using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject pause;
    public GameObject inGame;

    void Start()
    {
        gameOver.SetActive(false);
        pause.SetActive(false);
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
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
        SceneManager.LoadScene(0);
    }
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
        PlayerPrefs.DeleteAll();
    }
}
