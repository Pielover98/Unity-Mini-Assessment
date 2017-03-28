using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Vector3 spawnPoint;
    public float lives = 5.0f;
    public bool dead = false;
    public bool gameOver = false;


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Destroy")
        {
            dead = true;
        }
    }
    void OnCollisionEnter(Collision ball)
    {
        if(ball.gameObject.tag == "LavaBall")
        {
            dead = true;
        }
    }
       
	// use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (dead == true)
        {
            transform.position = spawnPoint;
            lives--;
            dead = false;
        }
        if (lives <= 0)
        {
            gameOver = true;
        }
        if (gameOver == true)
        {
            Application.LoadLevel(3);
        }

    }
}
