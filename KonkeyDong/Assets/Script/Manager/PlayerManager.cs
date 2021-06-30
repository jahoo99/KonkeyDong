using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoSingleton<PlayerManager>
{

    private int _health = 7;
    private void Start()
    {
        HealthLoss(0);
    }
    public void HealthLoss(int _damage)
    {
        _health -= _damage;
        if (_damage!=0)
        {
        AudioManager.Instance.GettingHit();
        }
        ReferenceManager.Instance.HPTextUpdate(_health);
        HealthCheck();
    }
    public void HealthCheck()
    {
        if (_health<=0)
        {
            _health = 0;
            LevelManager.Instance.Restart();
        }
    }
    private int _points = 0;
    private int _winCondition = 4;
    private int _winPoints = 0;
    private int _healthUpCondition = 5;
    private int _healthAdded = 5;


    public void AddPoints(int pointsAdded)
    {
        _points += pointsAdded;
        if (_points > _healthUpCondition)
        {
            _points -= 5;
            _winPoints++;
            _health += _healthAdded;
            AudioManager.Instance.HealthUp();
            ReferenceManager.Instance.HPTextUpdate(_health);
        }
        else
        {
            AudioManager.Instance.PointUp();
        }
        ReferenceManager.Instance.ScoreUpdate(_points);        
    }

}
