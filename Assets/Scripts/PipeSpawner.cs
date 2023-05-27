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
    SpriteRenderer button;

    void Start()
    {
        button = GameObject.Find("PlayButton").GetComponent<SpriteRenderer>();
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position += new Vector3(0, Random.Range(-down, up), 0);
    }

    void Update()
    {
        if(button.enabled == false)
        {
            if(timer > maxTime)
            {
                GameObject newpipe = Instantiate(pipe);
                newpipe.transform.position += new Vector3(0, Random.Range(-down, up), 0);
                Destroy(newpipe, 15);
                timer = 0;
            }
            timer += Time.deltaTime;
        }

    }
}
