using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YRotateStick : MonoBehaviour
{
    public float rotatingSpeed = 10f;
    void Update() {
        transform.Rotate(Vector3.down, rotatingSpeed * Time.deltaTime);
    }
}
