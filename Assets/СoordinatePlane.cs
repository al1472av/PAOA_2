using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class СoordinatePlane : MonoBehaviour
{
    [SerializeField] private RectTransform _plane;
    [SerializeField] private Transform _xAxis, _yAxis, _content;
    [SerializeField] private CoordinatePointView _coordinatePointView;
    [SerializeField] private Image _pointPrefab;

    public void Setup(Vector2Int Size)
    {
        _plane.sizeDelta = new Vector2((Size.x + 1) * 100, (Size.y + 1) * 100);
        SetCoordinates();
    }

    private void SetCoordinates()
    {
        for (int i = 0; i < _plane.sizeDelta.x / 100 + 1; i++)
        {
            var coordinatePointView = Instantiate(_coordinatePointView, _xAxis);
            coordinatePointView.SetPositionX(i);
        }

        for (int i = 0; i < _plane.sizeDelta.x / 100 + 1; i++)
        {
            var coordinatePointView = Instantiate(_coordinatePointView, _yAxis);
            coordinatePointView.SetPositionY(i);
        }
    }

    public void SpawnPoints(Vector2Int[] points, Color color)
    {
        foreach (var t in points)
            SpawnPoint(t, color);
    }

    public void SpawnPoint(Vector2Int points, Color color)
    {
        var point = Instantiate(_pointPrefab, _content);
        point.rectTransform.anchoredPosition = new Vector2(100 * points.x, 100 * points.y);
        point.color = color;
    }
}