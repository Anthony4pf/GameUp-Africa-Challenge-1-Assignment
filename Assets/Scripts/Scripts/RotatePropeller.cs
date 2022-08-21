using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    private float rotateAngle = 40.0f;
    
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(Vector3.forward, rotateAngle);
    }
}
