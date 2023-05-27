using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayButton : MonoBehaviour
{
    TMP_Text playtext;
    TMP_Text flappytext;
    SpriteRenderer button;

    public GameObject bird;
    
    void Start()
    {
        playtext = GameObject.Find("PlayText").GetComponent<TMP_Text>();
        flappytext = GameObject.Find("FlappyText").GetComponent<TMP_Text>();
        button = GameObject.Find("PlayButton").GetComponent<SpriteRenderer>();
        //Bird este selectat direct din unity(vezi playbutton)
        bird.SetActive(false);
    }

    void OnMouseDown()
    {
        playtext.text = "";
        flappytext.text = "";
        button.enabled = false;
        bird.SetActive(true);
    }
}
