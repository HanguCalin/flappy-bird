using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalPlayButton : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Second");
    }
}
