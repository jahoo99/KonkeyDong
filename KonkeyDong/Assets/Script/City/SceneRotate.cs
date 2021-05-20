using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SceneRotate : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    void Update()
    {
        transform.Rotate(0 , _speed* Time.deltaTime, 0 ); //rotates 50 degrees per second around z axis
     }
}
