using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComplete : MonoBehaviour, IPlayerCollision
{
    public void PlayerTouch()
    {
        LevelManager.Instance.QuitGame();
    }
}
