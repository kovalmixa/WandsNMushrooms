using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionArrows : MonoBehaviour
{
    public Sprite centerImage;
    public Color color;
    public Action<Vector2, string> onArrowClick;
    public GameObject Player;

    public string type;
    void Start()
    {
        onArrowClick = Player.GetComponent<Player>().Action;
        foreach (var button in GetComponentsInChildren<Button>())
        {
            button.GetComponent<ArrowButton>().onArrowClick += onArrowClick;
            button.GetComponent<ArrowButton>().type = type;
            button.GetComponent<Image>().color = color;
        }
        Transform ActionImage = transform.Find("Image");
        ActionImage.GetComponent<Image>().sprite = centerImage;
    }
}
