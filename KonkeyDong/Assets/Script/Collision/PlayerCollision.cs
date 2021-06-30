using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour{
    void OnTriggerEnter(Collider other)
    {
        IPlayerCollision[] list = other.gameObject.GetComponents<IPlayerCollision>();
        foreach (IPlayerCollision mb in list)
        {
            if (mb is IPlayerCollision)
            {
                IPlayerCollision breakable = (IPlayerCollision)mb;
                breakable.PlayerTouch();
            }
        }
    }

}
