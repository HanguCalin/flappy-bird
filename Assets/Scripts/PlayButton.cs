using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayButton : MonoBehaviour
{
   // TMP_Text playtext;
  //  TMP_Text flappytext;
 //   public GameObject button;
//    public GameObject bird;

    //public bool start = false;
    void Start()
    {
        //playtext = GameObject.Find("PlayText").GetComponent<TMP_Text>();
        //flappytext = GameObject.Find("FlappyText").GetComponent<TMP_Text>();
        //button = GameObject.Find("PlayButton");
        //Bird este selectat direct din unity(vezi playbutton)
        //bird.SetActive(false);
    }

    void OnMouseDown()
    {
        //playtext.text = "";
        //flappytext.text = "";
        //button.SetActive(false);
        //bird.SetActive(true);
        SceneManager.LoadScene("Second");   
    }
}
