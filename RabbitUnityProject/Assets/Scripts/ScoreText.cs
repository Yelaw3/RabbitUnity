﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int points = 0; 

    void OnGUI() //Faire apparaître un texte de score
    {
        GUI.Label(new Rect(80, 50, 200, 100), points + "/3");
    }
}
