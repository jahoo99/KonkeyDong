using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BarrelJump : MonoBehaviour
{
    [SerializeField] private Ease _animType;
    [SerializeField] private int _jumpAmount = 0;
    [SerializeField] private float _jumpDistance = 0;
    [SerializeField] private float _jumpDuration = 0;
    [SerializeField] private float _jumpHeight = 0;
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
    private void Jump()
    {
        if (_jumpAmount>0)
        {
          //  Debug.Log(transform.position.x);
            _rb.DOJump(new Vector3(transform.position.x - _jumpDistance, _y, _z), _jumpHeight, _jumpRepetition, _jumpDuration, false).SetEase(_animType).OnComplete(() =>
            {
                _jumpAmount--;
                SnapPosition();
                Jump();
            });
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void SnapPosition()
    {
        int posx = Mathf.RoundToInt(transform.position.x);
        int posy = Mathf.RoundToInt(transform.position.y);
        transform.position = new Vector3(posx, posy, _z);
    }

}
