using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        MonoBehaviour[] list = other.gameObject.GetComponents <MonoBehaviour > ();
        foreach (MonoBehaviour mb in list)
         {
            if (mb is IBarrel)
            {
                IBarrel breakable = (IBarrel)mb;
                breakable.Barrel();
            }
        }


       // Debug.Log(other.gameObject.name);
        //IBarrel testInterface = other as IBarrel;

        //if (testInterface != null)
        //{
        //    testInterface.Barrel();
        //}
    }
}
