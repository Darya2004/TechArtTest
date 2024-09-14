using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCamera : MonoBehaviour
{
    public float scaleX = 1f;
    public float scaleY = 1f;
    float cornerAngle = 0f;
    void FixedUpdate()
    {
        //transform.position = new Vector3(45+0.25f * Mathf.Cos(Time.time * 4), 50+0.25f * Mathf.Sin(Time.time * 4), 45);
        cornerAngle += Time.deltaTime*1.5f;
        transform.position = new Vector3(45+Mathf.Cos(cornerAngle) * scaleX, 50+Mathf.Sin(cornerAngle) * Mathf.Cos(cornerAngle) * scaleY, 45);
    }
}
