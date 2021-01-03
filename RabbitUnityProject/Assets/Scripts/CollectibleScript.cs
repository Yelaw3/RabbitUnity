using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public float rotateSpeed = 30f;
    public GameObject collectEffect;
    public int points = 0;

    private void Update() //Faire tourner l'objet sur lui même
    {
        transform.Rotate(Vector3.up * rotateSpeed);
    }
    private void OnTriggerEnter(Collider other) //Quand un objet entre en collision avec le joueur, on ajoute un point au score & on déclenche un FX à la position de cet objet, puis on désactive celui-ci
    {
        if (other.tag == "Player")
        {
            other.GetComponent<ScoreText>().points++;
            Instantiate(collectEffect, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }
    }

}

