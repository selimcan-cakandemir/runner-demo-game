using UnityEngine;

public class AIDetection : MonoBehaviour {

    Rigidbody rb;
    public float sideStep;
    public float moveSpeed;
    private Vector3 moveInput;
    private Vector3 moveVelocity;
    public static bool rightBlocked;
    public static bool leftBlocked;


    void Start() {
        rb = GetComponentInParent<Rigidbody>();
    }

    void Update() {
        moveInput = new Vector3(0f, 0f, 1f);
        moveVelocity = moveInput * moveSpeed;
    }

    void FixedUpdate() {
        rb.velocity = moveVelocity;
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Obstacle") {
            if (rightBlocked == true) {
                rb.AddForce(new Vector3(-1f, 0, 0f) * sideStep, ForceMode.Impulse);
            }
            if (leftBlocked == true) {
                rb.AddForce(new Vector3(1f, 0, 0f) * sideStep, ForceMode.Impulse);
            }
            else if (!rightBlocked && !leftBlocked) {
                rb.AddForce(new Vector3(-1f, 0, 0f) * sideStep, ForceMode.Impulse);
            }
            
        }
    }
}
