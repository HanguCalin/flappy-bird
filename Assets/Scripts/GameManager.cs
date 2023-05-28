using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public bool gameOver = false; 
    public TMP_Text scoreText;
    public GameObject button;
    public GameObject resetButton;
    public GameObject gameOverText;

    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
        button = GameObject.Find("PlayButton");
        resetButton = GameObject.Find("ResetButton");
        gameOverText = GameObject.Find("GameOverText");
        resetButton.SetActive(false);
        gameOverText.SetActive(false);
    }

    void Update()
    {
            string toString = score.ToString();
            scoreText.text = toString;
            if(gameOver == true)
            {
                gameOverText.SetActive(true);
                resetButton.SetActive(true);
            }
    }
}
