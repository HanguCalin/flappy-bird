using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimation : MonoBehaviour
{
    public Sprite[] sprites;
    public int framesPerSecond;
    public static SpriteRenderer spriterenderer;
    
    private int currentSpriteIndex;
    private float timer;
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        currentSpriteIndex = 0;
        spriterenderer.sprite = sprites[currentSpriteIndex];
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1.0f / framesPerSecond)
        {
            currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length;
            spriterenderer.sprite = sprites[currentSpriteIndex];
            timer -= 1.0f / framesPerSecond;
        }
    }
}
