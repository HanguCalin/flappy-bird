using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            GetComponent<BirdPhysics>().enabled = false;
            GetComponent<BirdAnimation>().enabled = false;
            GetComponent<GameManager>().gameOver = true;
            //Time.timeScale = 0;(Face Time.deltaTime = 0, pe scurt opreste tot dar nu o sa mai poti face pasarea sa cada)
            FindObjectOfType<PipeSpawner>().enabled = false;
            foreach (MovingBackground mover in FindObjectsOfType<MovingBackground>())
                mover.enabled = false;
            foreach (PipeMove pipeMove in FindObjectsOfType<PipeMove>())
                pipeMove.enabled = false;
        }
        else if(collision.tag == "Point")
        {
            GetComponent<GameManager>().score++;
        }
    }
}
