using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float _force;
    private Rigidbody _rb;
    private void Awake()
    {
      
    }
    void Update()
    {
        transform.Translate( Vector3.down* Time.deltaTime* _force);
    }
}
