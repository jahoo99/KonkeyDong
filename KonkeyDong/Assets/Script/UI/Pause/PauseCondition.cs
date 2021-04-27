using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCondition : MonoBehaviour
{
    //[SerializeField] private GameObject PausePanel;

    [SerializeField] private Pause _pause;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Activation();
        }
    }
    private void Activation()
    {
        _pause.PauseActivation();
    }
}
