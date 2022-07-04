using UnityEngine;

public class RotatePlatform : MonoBehaviour{

    public float rotatingSpeed = 10f;

    void Update() {
        transform.Rotate(Vector3.forward, rotatingSpeed * Time.deltaTime);
    }
}
