using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        IBarrel[] list = other.gameObject.GetComponents<IBarrel>();
        foreach (IBarrel mb in list)
         {
            if (mb is IBarrel)
            {
                IBarrel breakable = (IBarrel)mb;
                breakable.Barrel();
            }
        }


       
    }
}
