using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddingPointsOnUI : MonoBehaviour
{
    [SerializeField] private Text _text;
    
    
    public void UpdatePoints(int points)
    {
        _text.text = points.ToString();
    }
}
