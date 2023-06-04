using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    public GameObject pipe;
    public float up;
    public float down;

    private float timer = 0;
  //  GameObject button;

    void Start()
    {
        //button = GameObject.Find("PlayButton");
        //GameObject newpipe = Instantiate(pipe);
        //newpipe.transform.position += new Vector3(0, Random.Range(-down, up), 0);
    }

    void Update()
    {
            if(timer > maxTime)
            {
                GameObject newpipe = Instantiate(pipe);
                newpipe.transform.position += new Vector3(0, Random.Range(-down, up), 0);
                timer = 0;
            }
            timer += Time.deltaTime;
    }
}
