using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{ 
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Application.LoadLevel(4);
        }
    }
}
