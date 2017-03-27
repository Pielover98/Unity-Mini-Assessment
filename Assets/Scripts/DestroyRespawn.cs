using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyLavaBall : MonoBehaviour
{
    public GameObject LavaBall;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroy")
        {
            Destroy(LavaBall);
        }
    }
    void Update()
    {
        Destroy(LavaBall, 10);
    }
}
