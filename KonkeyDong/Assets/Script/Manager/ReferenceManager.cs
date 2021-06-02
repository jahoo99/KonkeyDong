using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceManager : MonoSingleton<ReferenceManager>
{

    [SerializeField]private AddingPointsOnUI _pointsUI;
    public void ScoreUpdate(int points)
    {
        _pointsUI.UpdatePoints(points);
    }
    [SerializeField] private HealthTaking _healthUI;
    public void HPTextUpdate(int health) {
        _healthUI.UpdateHealth(health);
    }
}
