using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkController : MonoBehaviour
{
    public ParticleSystem firework1;
    public ParticleSystem firework2;
    public ParticleSystem firework3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            firework1.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            firework2.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            firework3.Play();
        }
    }
}