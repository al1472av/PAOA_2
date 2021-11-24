using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private СoordinatePlane _coordinatePlane;


    public void OnInputEndTargetPoint(InputField inputField)
    {
        var values = inputField.text;
        var x = Convert.ToInt32(values.Split(' ')[0]);
        var y = Convert.ToInt32(values.Split(' ')[1]);
        _coordinatePlane.SpawnPoint(new Vector2Int(x,y), Color.red);
    }
    
    public void OnInputEnd(InputField inputField)
    {
        var values = inputField.text;
        
        foreach (var value in values)
        {
            Debug.Log(value);
        }
        
        var splitValues = values.Split('\n');

        foreach (var value in splitValues)
        {
            Debug.Log(value);
        }
        
        List<Vector2Int> points = new List<Vector2Int>();
        foreach (var t in splitValues)
        {
            var x = Convert.ToInt32(t.Split(' ')[0]);
            var y = Convert.ToInt32(t.Split(' ')[1]);
            points.Add(new Vector2Int(x,y));
        }
        
        _coordinatePlane.Setup(new Vector2Int(points.Max(t => t.x),points.Max(t => t.y)));
        _coordinatePlane.SpawnPoints(points.ToArray(), Color.green);
    }
}
