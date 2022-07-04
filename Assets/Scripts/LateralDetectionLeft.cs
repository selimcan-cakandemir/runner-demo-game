using UnityEngine;

public class LateralDetectionLeft : MonoBehaviour{

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Wall") {
            AIDetection.leftBlocked = true;
        }      
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Wall") {
            AIDetection.leftBlocked = false;
        }        
    }
}
