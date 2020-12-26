using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePlayer : MonoBehaviour
{
    public float height;
    public GameObject player;
    private Vector3 offset = new Vector3(0, 0.5f, 0.8f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset * height;
    }
}
