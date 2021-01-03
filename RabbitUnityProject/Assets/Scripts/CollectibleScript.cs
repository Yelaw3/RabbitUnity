﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public float rotateSpeed = 30f;
    public GameObject collectEffect;
    public int points = 0;

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

}

