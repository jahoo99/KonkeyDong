using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BarrelJump : MonoBehaviour
{
    [SerializeField] private int _jumpAmount;
    [SerializeField] private float _jumpDistance;
    [SerializeField] private float _jumpDuration;
    [SerializeField] private float _jumpHeight;
    private float _z;
    private float _y;
    private const int _jumpRepetition = 1;
    private Vector3 _jumpPlace;
    private Rigidbody _rb;
   

    private void Awake()
    {
        _z = transform.position.z;
        _y = transform.position.y;
        //_jumpPlace = new Vector3(0,0, transform.position.z + _jumpDistance);
        _rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Jump();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void Jump()
    {
        if (_jumpAmount>0)
        {
          //  Debug.Log(transform.position.x);
            _rb.DOJump(new Vector3(transform.position.x - _jumpDistance, _y, _z), _jumpHeight, _jumpRepetition, _jumpDuration, false).OnComplete(() =>
            {
                _jumpAmount--; 
                Jump();
            });
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

}
