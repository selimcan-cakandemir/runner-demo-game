using UnityEngine;

public class RotateStick : MonoBehaviour{

    public float rotatingSpeed = 10f;
    void Update() {
        transform.Rotate(Vector3.right, rotatingSpeed * Time.deltaTime);
    }
}
