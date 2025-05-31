using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 10;
    public Rigidbody2D rigid;

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.AddTorque(rotateSpeed);
    }
}
