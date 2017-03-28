using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenu : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKey(KeyCode.Q))
        {
            Application.LoadLevel(1);
        }	
        if(Input.GetKey(KeyCode.W))
        {
            Application.LoadLevel(2);
        }
        if(Input.GetButton("MainMenu"))
        {
            Application.LoadLevel(0);
        }
        if(Input.GetButton("Quit"))
        {
            Application.Quit();
        }
	}
}
