using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountCarrots : MonoBehaviour
{
    public GameObject objUI;

    void Start() //Trouver le Game Object "Score"
    {
        objUI = GameObject.Find("Score");
    }

    void Update() //Si dans le script CollectCarrots le nombre d'objets actifs = 0, alors on affiche un texte et on quitte le jeu
    {
        if (CollectCarrots.objects == 0)
        {
            objUI.GetComponent<Text>().text = "All carrots are collected, well done !";
            Application.Quit();
        }
    }
}