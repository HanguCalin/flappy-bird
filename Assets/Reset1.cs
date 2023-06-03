using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Reset1 : MonoBehaviour
{
    public GameObject resetButton;
    public GameObject gameOverText;
    public TMP_Text bestscoreText;
    GameManager bird;

    void Start()
    {
        bird = GameObject.Find("Bird").GetComponent<GameManager>();
        resetButton = GameObject.Find("ResetButton");
        gameOverText = GameObject.Find("GameOverText");
    }

    void OnMouseDown()
    {
        FindObjectOfType<GameManager>().gameOver = false;
        resetButton.SetActive(false);
        gameOverText.SetActive(false);
        SceneManager.LoadScene("SecondReskin");
    }
}
