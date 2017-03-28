using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public Transform target;
    public float turretSpeed;
    public float fireRate;
    public float LavaBallHeight;
    public GameObject TurretLavaBall;
    public float range;
    float distance;
    float fireTimer = 0.0f;

    public Transform firepoint;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   
        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        rotation.x = 0;
        rotation.z = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * turretSpeed);

        distance = Vector3.Distance(transform.position, target.position);

        if (distance < range)
        {
            fireTimer += Time.deltaTime;
            if (fireTimer >= fireRate)
            {
                fireTimer -= fireRate;
                launchLavaBall();
            }
        }
    }

    void launchLavaBall()
    {
        Vector3 position = new Vector3(transform.position.x, transform.position.y + LavaBallHeight, transform.position.z );
        GameObject lava = Instantiate(TurretLavaBall, firepoint.position, firepoint.rotation);

        Rigidbody babyRbody = lava.GetComponent<Rigidbody>();
        babyRbody.AddForce(transform.forward * 30, ForceMode.Impulse);
    }
}