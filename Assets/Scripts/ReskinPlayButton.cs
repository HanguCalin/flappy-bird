using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReskinPlayButton : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("SecondReskin");
    }
}
