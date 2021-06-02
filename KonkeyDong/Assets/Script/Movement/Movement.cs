using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Movement : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float m_Speed = 5f;
    [SerializeField] private float _jumpForce = 500;
    private 

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.DOMoveX(transform.position.x + m_Input.x, 1, false);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
         _rb.AddForce(Vector3.up* _jumpForce);
        Debug.Log("No działa");
        
    }
}
