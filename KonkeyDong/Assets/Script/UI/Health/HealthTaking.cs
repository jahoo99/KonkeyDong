using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HealthTaking : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;


    public void UpdateHealth(int health)
    {
        _text.text = health.ToString();
    }
}
