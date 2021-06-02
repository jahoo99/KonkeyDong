using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour, IPlayerCollision
{
    [Range(1,10)]
    [SerializeField]private int _crystalAmount = 0;
   public void PlayerTouch()
    {
        PlayerManager.Instance.AddPoints(_crystalAmount);
        Destroy(transform.parent.gameObject);
    }
}
