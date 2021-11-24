using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoordinatePointView : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void SetNumber(int number)
    {
        _text.text = number.ToString();
    }

    public void SetPositionX(int number)
    {
        var rt = ((RectTransform) transform);
        rt.anchoredPosition = new Vector2(number * 100, rt.rect.height / 2);
        SetNumber(number);
    }
    
    public void SetPositionY(int number)
    {
        var rt = ((RectTransform) transform);
        rt.anchoredPosition = new Vector2( rt.rect.width / 2,number * 100);
        SetNumber(number);
    }
}