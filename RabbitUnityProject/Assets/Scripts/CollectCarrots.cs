using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCarrots : MonoBehaviour
{
    public static int objects = 0; //créer un objet
    void Awake() //Pour chaque objet qui possède ce script, on ajoute un objet à la variable int "objects"
    {
        objects++;
    }

    void OnTriggerEnter(Collider other) //Quand l'objet entre en collision avec le joueur, on enlève un objet de la variable int "objects"
    {
        if (other.gameObject.tag == "Player")
        {
            objects--;
        }
    }
}