using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;
    private Rigidbody myRigidbody;
    private Animator animator;
    private Vector3 moveInput;
    private Vector3 moveVelocity;


    public float vel;
    public float moveAccRate;
    public float dampeningCoEfficient;
    public float rotationScale;

    void Start() {
        myRigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update() {
        //Sag/sol hareket
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, 1f);
        moveVelocity = moveInput * moveSpeed;

        //Velocity bazli rotasyon - karakterin sag ve sola kaymasi
        float acc = 0;
        if (Input.GetKey(KeyCode.D)) acc -= moveAccRate;
        if (Input.GetKey(KeyCode.A)) acc += moveAccRate;

        //velocity hesabi (framerate bagimsiz olmasi icin Time.deltaTime ile carpiyoruz
        vel += acc * Time.deltaTime;
        vel = Mathf.Lerp(vel, 0, dampeningCoEfficient * Time.deltaTime);

        //rotasyon hesabi
        transform.rotation = Quaternion.Euler(0, 0, vel * rotationScale);

        //transform'a uygulama
        //transform.position += new Vector3(vel * Time.deltaTime, 0, 0);
    }

    //Fizik hesaplamalarini fixed bir sekilde çagirilan FixedUpdate altina koyuyoruz
     void FixedUpdate() {
        myRigidbody.velocity = moveVelocity;
    }

    private void OnCollisionEnter(Collision collision) {
        //Seviye resetleme
        if (collision.gameObject.tag == "Obstacle") {
            GameManager.ResetLevel();
        }
        //Donen platformun uzerine gelince beraber hareket etmesi icin
        if (collision.gameObject.CompareTag("Rotating")) {

            this.transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.CompareTag("Rotating"))
            this.transform.parent = null;
    }
}
