using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountCarrots : MonoBehaviour
{
    public GameObject objUI;
    // Use this for initialization
    void Start()
    {
        objUI = GameObject.Find("Score");
    }
    // Update is called once per frame
    void Update()
    {
        objUI.GetComponent<Text>().text = CollectCarrots.objects.ToString();

        if (CollectCarrots.objects == 0)
        {
            objUI.GetComponent<Text>().text = "All carrots are collected, well done !";
            Application.Quit();
        }
    }
}