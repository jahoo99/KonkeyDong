using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleRocket : MonoBehaviour
{
    [SerializeField] private GameObject _explosionEffect;
    public void ParticleDestroy()
    {
        Instantiate(_explosionEffect, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
