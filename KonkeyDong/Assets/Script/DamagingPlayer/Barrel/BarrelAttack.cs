using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelAttack : MonoBehaviour, IPlayerCollision
{
    [Range(1, 10)]
    [SerializeField] private int _damage = 1;
    [SerializeField] private ParticleRocket _pr = null;
    private int _amount = 0;

    public void PlayerTouch()
    {
        _amount++;
        if (_amount>=1)
        {
            PlayerManager.Instance.HealthLoss(_damage);
        }
        if (_pr != null)
        {
            _pr.ParticleDestroy();
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }
}
