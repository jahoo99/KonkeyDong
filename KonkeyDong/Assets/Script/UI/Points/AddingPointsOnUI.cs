using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class AddingPointsOnUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    
    
    public void UpdatePoints(int points)
    {
        _text.text = points.ToString();
    }
}
