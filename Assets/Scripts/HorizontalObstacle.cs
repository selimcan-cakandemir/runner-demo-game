using UnityEngine;

public class HorizontalObstacle : MonoBehaviour {

    private Vector3 pos;
    public float speed;
    public float distance;
    public float offset;

    void Start() {
        pos = transform.position;
    }

    void Update() {
        transform.position = pos + transform.right * Mathf.Sin(Time.time * speed + offset) * distance;
    }
}
