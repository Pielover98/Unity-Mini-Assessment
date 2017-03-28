using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	if(Input.GetButton("Quit"))
        {
            Application.Quit();
        }	
    if(Input.GetButton("Start"))
        {
            Application.LoadLevel(1);
        }
    if(Input.GetButton("LevelMenu"))
        {
            Application.LoadLevel(5);
        }
	}
}
