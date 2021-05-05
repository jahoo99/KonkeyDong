using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadMenuPopUp : MonoBehaviour
{

    [SerializeField]private GameObject _deadUI;
    private void Start()
    {
        _deadUI.SetActive(false);
    }

    public void TurningOn()
    {
        _deadUI.SetActive(true);
    }
}
