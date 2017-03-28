using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPinWheelObsticle : MonoBehaviour {

    public float DegPerSec = 90.0f;

    private void Update()
    {
        transform.Rotate(Vector3.forward, DegPerSec * Time.deltaTime, Space.World);
    }
}