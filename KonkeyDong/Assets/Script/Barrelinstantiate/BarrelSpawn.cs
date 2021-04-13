using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _barrelPrefab;
    [SerializeField] private float _spawnTime = 100f;
    [SerializeField] private Transform _barrelPlace;
    void Start()
    {
        StartCoroutine(BarrelSpawnLoop());
    }
    IEnumerator BarrelSpawnLoop()
    {
       
        while (true)
        {
            Instantiate(_barrelPrefab, _barrelPlace.localPosition, _barrelPlace.localRotation);
            yield return new WaitForSeconds(_spawnTime);
           
            
            
        }
    }

}
