using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 5f;
    public GameObject CollectCarrotsText;

    void Start()
    {
        CollectCarrotsText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, time);
    }
}
