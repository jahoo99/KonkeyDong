using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTaking : MonoBehaviour, IBarrel
{
    
    public void Barrel()
    {
        PlayerManager.Instance.HealthLoss(3);
    }
}
