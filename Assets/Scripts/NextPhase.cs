using System.Collections;
using UnityEngine;
using TMPro;

public class NextPhase : MonoBehaviour {

    TextMeshProUGUI text;

    public void Start() {
        text = GameObject.Find("Canvas").gameObject.transform.Find("Text").gameObject.GetComponent<TextMeshProUGUI>();
    }

    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            GameManager.StopPlayer();
            WriteText("You win!");       
            StartCoroutine("WaitRest");
        }
        if(other.gameObject.tag == "Girl") {
            WriteText("You lose!");
            StartCoroutine("WaitRest");
        }
    }

     IEnumerator WaitRest() {
        yield return new WaitForSeconds(3f);
        GameManager.ResetLevel();
    }

    public void WriteText(string conText) {
        if (text.text == "") {
            text.text = conText;
        }
    }

}
