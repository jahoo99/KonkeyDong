using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
//    [SerializeField] private ClimbingLadder _cl;
    [SerializeField] private Rigidbody _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log("aaaaaaaaa");
        if (other.GetComponent<LadderCollision>())
        {
            _rb.useGravity = false;
        }

    }

}
