﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Movement>())
        {
            LevelManager.Instance.NextLevel();
        }
    }
}
