using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    public int speed;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        spriteRenderer.material.mainTextureOffset += new Vector2(Time.deltaTime / speed, 0);
    }
}
