using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCondition : MonoBehaviour
{
    [SerializeField] private Destroy _barrel;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.GetComponent<PlayerCollision>())
        {
            _barrel.DestroyObject();
            LevelManager.Instance.Restart();
        }
    }
}
