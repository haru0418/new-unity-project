﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageChange : MonoBehaviour
{
    public Sprite newSprite;
    void Start()
    {
        Image image = GetComponent<Image>();
        image.sprite = newSprite;
        image.color = new Color(0f,1f,0f,1f);
    }
}