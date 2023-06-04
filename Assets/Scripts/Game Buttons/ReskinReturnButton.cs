using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReskinReturnButton : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("GameMode");
    }
}
