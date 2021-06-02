using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoSingleton<PlayerManager>
{

    private int _health = 7;
    public void HealthLoss(int _damage)
    {
        _health -= _damage;
        ReferenceManager.Instance.HPTextUpdate(_health);
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
    private int _points = 0;
    private int _winCondition = 20;
    public void AddPoints(int pointsAdded)
    {
        _points += pointsAdded;
        ReferenceManager.Instance.ScoreUpdate(_points);

        if (_points>=_winCondition)
        {
            LevelManager.Instance.NextLevel();
        }
    }
}
