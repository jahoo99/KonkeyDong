using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        //if (other.gameObject.name)
        //{
        //    Debug.Log("No się klikło no ");
        //}

    }

}
