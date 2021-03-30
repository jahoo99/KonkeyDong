using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _barrelPrefab;
    [SerializeField] private float _spawnTime = 100f;
    void Start()
    {
        //GameObject a = Instantiate(_barrelPrefab) as GameObject;
        StartCoroutine(BarrelSpawnLoop());
    }
    IEnumerator BarrelSpawnLoop()
    {
        //GameObject a = Instantiate(_barrelPrefab) as GameObject;
        while (true)
        {
            GameObject a = Instantiate(_barrelPrefab) as GameObject;
            yield return new WaitForSeconds(_spawnTime);
           
            
            
        }
    }

}
