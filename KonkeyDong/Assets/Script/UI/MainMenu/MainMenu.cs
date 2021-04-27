using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        LevelManager.Instance.FirstLevel();
    }
    public void Quit()
    {
        LevelManager.Instance.QuitGame();
    }
}
