using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public GameObject resetButton;
    public GameObject gameOverText;

    void Start()
    {
        resetButton = GameObject.Find("ResetButton");
        //scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
        gameOverText = GameObject.Find("GameOverText");
    }

    void OnMouseDown()
    {
        FindObjectOfType<GameManager>().gameOver = false;
        resetButton.SetActive(false);
        gameOverText.SetActive(false);
        SceneManager.LoadScene("Second");
    }
}
