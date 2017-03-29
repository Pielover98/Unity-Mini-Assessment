using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyLavaBall : MonoBehaviour
{
    public GameObject LavaBall;
    private AudioSource audioSource;
    public AudioClip BallSizzle;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroy")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = BallSizzle;
            audioSource.Play();
            Destroy(LavaBall);
        }
    }
    void Update()
    {
        Destroy(LavaBall, 10);
    }
}
