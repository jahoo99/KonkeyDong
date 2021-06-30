using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoSingleton<AudioManager>
{
    [SerializeField] private AudioSource _hitPlayerSound;
    [SerializeField] private AudioSource _healthUpSound;
    [SerializeField] private AudioSource _pointUpSound;
    [SerializeField] private AudioSource _rocketDieSound;


    public void GettingHit()
    {
        _hitPlayerSound.Play();
    }
    public void HealthUp()
    {
        _healthUpSound.Play();
    }
    public void PointUp()
    {
        _pointUpSound.Play();
    }
    public void _rocketDie()
    {
        _rocketDieSound.Play();
    }
}   
