using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 0f;

    void Update ()
    {
        speed = RotatorSpeed.Rotatorspeed;
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
