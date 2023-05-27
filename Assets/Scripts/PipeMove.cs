using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed;
    SpriteRenderer button;
    void Start()
    {
        button = GameObject.Find("PlayButton").GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(button.enabled == false)
            transform.position += Vector3.left * speed * Time.deltaTime;    
    }
}
