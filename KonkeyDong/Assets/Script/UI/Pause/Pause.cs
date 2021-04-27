using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject PausePanel;
    bool isActive;
    private void Start()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void PauseActivation()
    {
        PausePanel.SetActive(!PausePanel.activeSelf);
        LevelManager.Instance.StopTime();
    }
    public void MainMenu()
    {
        LevelManager.Instance.MainMenu();
    }
}
