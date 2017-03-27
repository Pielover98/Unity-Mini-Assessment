using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObsticle : MonoBehaviour
{

    public float DegPerSec = 90.0f;

    private void Update()
    {
        transform.Rotate(Vector3.up, DegPerSec* Time.deltaTime, Space.World);
    }
}