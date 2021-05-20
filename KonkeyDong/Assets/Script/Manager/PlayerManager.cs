using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoSingleton<PlayerManager>
{
    private int _health = 3; 
    public void HealthLoss(int _damage)
    {
        _health -= _damage;
        HealthCheck();
    }
    public void HealthCheck()
    {
        if (_health<=0)
        {
            _health = 0;
            Debug.Log("Die");
            LevelManager.Instance.Restart();
        }
    }    
}
