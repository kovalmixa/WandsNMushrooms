using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowButton : MonoBehaviour
{
    public Vector2 direction;
    public string type;
    public Action<Vector2, string> onArrowClick;
    public void Click()
    {
        onArrowClick?.Invoke(direction, type);
    }
}
