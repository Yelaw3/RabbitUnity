using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCarrots : MonoBehaviour
{
    public static int objects = 0;
    // Use this for initialization
    void Awake()
    {
        objects++;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objects--;
        }
    }
}