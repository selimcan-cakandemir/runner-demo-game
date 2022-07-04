using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 distance;
    public float speed;
    public Transform target;
   
    void FixedUpdate() {
        Vector3 distancePos = player.position + distance;
        Vector3 lerpPos = Vector3.Lerp(transform.position, distancePos, speed * Time.deltaTime);
        transform.position = lerpPos;
        transform.LookAt(target.position);

    }
}
