using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPhysics : MonoBehaviour
{

    public float gravity;
    public float strength;
    public bool doRotation;

    private Vector3 direction;
    public Rigidbody2D bird;

    void Start()
    {
        bird = GameObject.Find("Bird").GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bird.velocity = 1.5f * Vector2.up * strength;
        }

        //direction.y += gravity * Time.deltaTime;
        //transform.position += direction * Time.deltaTime;

        if (doRotation)
        {
            float rotation = bird.velocity.y * 0.75f;
            if (transform.rotation.z > 0.4f && rotation > 0) rotation = 0;
            else if (transform.rotation.z < -0.5f && rotation < 0) rotation = 0;
            transform.Rotate(0, 0, rotation, Space.Self);
            //transform.eulerAngles = new Vector3(0, 0, bird.velocity.y);
        }   
    }
   
}
