using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyRespawn : MonoBehaviour
{
    public GameObject LavaBall;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroy")
        {
            Destroy(LavaBall);
        }
    }
}
