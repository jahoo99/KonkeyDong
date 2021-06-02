using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelAttack : MonoBehaviour, IPlayerCollision
{
    [Range(1, 10)]
    [SerializeField] private int _damage = 1; 
    public void PlayerTouch()
    {
        PlayerManager.Instance.HealthLoss(_damage);
    }
    private void Start()
    {
        PlayerManager.Instance.HealthLoss(0);
    }
}
