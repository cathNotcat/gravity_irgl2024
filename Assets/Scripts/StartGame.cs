using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject rulesCanvas;
    private void Start()
    {
        rulesCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
        Debug.Log("New Scene");
    }
    public void Rules()
    {
        rulesCanvas.SetActive(true);
        Time.timeScale = 1;
    }
    public void Close()
    {
        rulesCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
        PlayerPrefs.DeleteAll();
        Debug.Log("exited");
    }

}
