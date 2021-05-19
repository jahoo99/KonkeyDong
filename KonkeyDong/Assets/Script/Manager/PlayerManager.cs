using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager _instance;
    public static PlayerManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject(typeof(PlayerManager).ToString());
                go.AddComponent<PlayerManager>();
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this as PlayerManager;
    }
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
            Debug.Log("Die");
            LevelManager.Instance.Restart();
        }

    }    
}
