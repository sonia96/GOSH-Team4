﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSkull : MonoBehaviour {

    float rotationSpeed = 20;

    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotationSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotationSpeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, -rotY);
    }
}
