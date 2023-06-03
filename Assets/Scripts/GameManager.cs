using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public bool gameOver = false;
    public static int highScore;

    private TMP_Text scoreText;
    private GameObject resetButton;
    private GameObject gameOverText;
    private TMP_Text bestscoreText;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("hs");

        bestscoreText = GameObject.Find("BestScoreText").GetComponent<TMP_Text>();
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
        resetButton = GameObject.Find("ResetButton");
        gameOverText = GameObject.Find("GameOverText");
        resetButton.SetActive(false);
        gameOverText.SetActive(false);
    }

    void Update()
    {
        string toString = score.ToString();
        scoreText.text = toString;

        string besttoString = highScore.ToString();
        bestscoreText.text = besttoString;

        if(gameOver == true)
        {
            gameOverText.SetActive(true);
            resetButton.SetActive(true);
            if(score > highScore)
            {
                bestscoreText.text = toString;
                highScore = score;
            }

            PlayerPrefs.SetInt("hs", highScore);
        }
    }
}
