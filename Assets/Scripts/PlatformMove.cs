using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlatformMove : MonoBehaviour
{
    public float speed = 3;

    float dir = 1;

    void Update()
    {

        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * dir * speed);
    }


    void OnTriggerEnter(Collider coll)
    { 
        if (coll.gameObject.tag == "Reverse")
        {
            dir *= -1;
        }
    }

}