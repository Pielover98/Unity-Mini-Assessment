using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : MonoBehaviour
{
    public Rigidbody trapDoor;
    public GameObject trap;
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            trapDoor.useGravity = true;
            trapDoor.isKinematic = false;
        }
    }
    void OnTriggerEnter(Collider colid)
    {
        if(colid.gameObject.tag == "Destroy")
        {
            Destroy(trap);
        }
    }
}
