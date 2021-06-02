using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTaking : MonoBehaviour
{
    [SerializeField] private Text _text;


    public void UpdateHealth(int health)
    {
        _text.text = health.ToString();
    }
}
