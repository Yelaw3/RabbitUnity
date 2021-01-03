using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText : MonoBehaviour
{
    
    public float time = 5f;
    public GameObject CollectCarrotsText;

    void Start()
    {
        CollectCarrotsText.SetActive(true); //Faire apparaitre le texte "CollectCarrotsText" au début de la partie
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(CollectCarrotsText, time); //Faire disparaître le text après 5 secondes
    }
}
