using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPhysics : MonoBehaviour
{

    public float gravity;
    public float strength;
    public bool doRotation;
    public Rigidbody2D bird;
    public AudioSource audioSound;

    private Vector3 direction;

    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSound.Play();
            bird.velocity = 1.5f * Vector3.up * strength;
        }

        if (doRotation)
        {
            float rotation = bird.velocity.y * 0.75f;
            if (transform.rotation.z > 0.4f && rotation > 0) rotation = 0;
            else if (transform.rotation.z < -0.5f && rotation < 0) rotation = 0;
            transform.Rotate(0, 0, rotation, Space.Self);
        }   
    }
   
}
