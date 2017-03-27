using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnPlatform : MonoBehaviour
{
void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.parent = gameObject.transform;
        }

    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.parent = null;
        }
    }
}