using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCollision : MonoBehaviour, IPlayerCollision
{
    public void PlayerTouch()
    {
        LevelManager.Instance.Restart();
    }
}
