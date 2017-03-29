using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownPlatformMove : MonoBehaviour
{
    public float speed = 3;

    float dir = 1;

    void Update()
    {

        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * dir * speed);
    }


    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Reverse")
        {
            dir *= -1;
        }
    }

}