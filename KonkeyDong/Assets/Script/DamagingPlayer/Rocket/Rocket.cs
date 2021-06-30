using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _forceMin;
    [SerializeField] private float _forceMax;
    [SerializeField] private int _rocketExistanceTime;
    
    [SerializeField] private ParticleRocket _pr = null;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(Random.Range(45, 135), 90, 0);
        _rb.velocity = transform.forward * Time.deltaTime * Random.Range(_forceMin, _forceMax);
        StartCoroutine(Explode());

    } 
    IEnumerator Explode()
    {

        yield return new WaitForSeconds(_rocketExistanceTime);
        if (_pr != null)
        {
            _pr.ParticleDestroy();
            AudioManager.Instance._rocketDie();
        }
        else
        {
            Destroy(this.gameObject);
        }
       
    }
}
