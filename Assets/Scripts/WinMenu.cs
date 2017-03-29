using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenu : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Quit"))
        {
            Application.Quit();
        }
        if(Input.GetButton("MainMenu"))
        {
            Application.LoadLevel(0);
        }
        if (Input.GetButton("LevelMenu"))
        {
            Application.LoadLevel(5);
        }
    }
}
