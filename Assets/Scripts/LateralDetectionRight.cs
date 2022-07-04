using UnityEngine;

public class LateralDetectionRight : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Wall") {
            AIDetection.rightBlocked = true;
        }  
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Wall") {
            AIDetection.rightBlocked = false;
        }    
    }

}
