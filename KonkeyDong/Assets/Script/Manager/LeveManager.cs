using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoSingleton<LevelManager>
{
   

    private int _buildIndex;
    protected override void OnAwake()
    {
        base.OnAwake();
       
        _buildIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private int _menu = 0;
    private int _lvl = 1;

    public void Restart()
    {
        SceneManager.LoadScene(_buildIndex, LoadSceneMode.Single); // to działa ale nie powinno, jest zjebane popraw
    }
    public void FirstLevel()
    {
        SceneManager.LoadScene(_lvl, LoadSceneMode.Single);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(_menu, LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    
    

    public void NextLevel()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single); // Napraw to, bo to jest gówniane 
    }

    private int _stop = 0;
    private int _resume = 1;

    public void StopTime()
    {
        if (Time.timeScale>0)
        {
            Time.timeScale = _stop;
        }
        else
        {
            Time.timeScale = _resume;
        }
    }
    public static bool gameIsPaused;
}