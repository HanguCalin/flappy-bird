using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPhysics : MonoBehaviour
{

    float speed;
    public float gravity;
    public float jumpForce;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            speed = jumpForce;
        }
        else
        {
            speed -= Time.deltaTime * gravity;
        }
        transform.position += new Vector3(0, Time.deltaTime * speed);
    }
}
