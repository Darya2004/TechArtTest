using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCamera : MonoBehaviour
{
    public float speed = 0.0005f;
    public float scaleX = 1f;
    public float scaleY = 1f;
    float cornerAngle = 0f;
    void FixedUpdate()
    {
        //transform.position = new Vector2(0.5f * Mathf.Cos(Time.time * 4), 0.5f * Mathf.Sin(Time.time * 4));
        //cornerAngle += Time.deltaTime*2;
        //transform.position = new Vector3(45+Mathf.Cos(cornerAngle) * scaleX, 50+Mathf.Sin(cornerAngle) * Mathf.Cos(cornerAngle) * scaleY, 45);
    }
}
