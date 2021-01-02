using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public float rotateSpeed = 30f;
    public GameObject ScoreText;
    public GameObject collectEffect;
    public int points = 0;
    public int fontSize = 20;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<ScoreText>().points++;
            Instantiate(collectEffect, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(80, 50, 200, 100), points + "/3");
        GUI.skin.label.fontSize = fontSize;
    }

}

