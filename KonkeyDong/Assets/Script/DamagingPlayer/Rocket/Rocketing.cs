using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketing : MonoBehaviour
{
    [SerializeField] private Transform _left;
    [SerializeField] private Transform _right;
    [SerializeField] private GameObject _rocketPrefab;
    void Start()
    {
        StartCoroutine(RocketSpawn());
    }

    IEnumerator RocketSpawn()
    {
        while (true)
        {
            GameObject a = Instantiate(_rocketPrefab) as GameObject;
            a.transform.position = new Vector3(Random.Range(_left.position.x, _right.position.x), _left.position.y, _left.position.z);
            yield return new WaitForSeconds(1);
        }
    }
}
