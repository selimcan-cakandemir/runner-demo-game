using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static void ResetLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public static void StopPlayer() {
        GameObject.Find("Boy").gameObject.GetComponent<PlayerController>().enabled = false;
        GameObject.Find("Boy").gameObject.GetComponent<Animator>().Play("Idle");
        GameObject.Find("Main Camera").gameObject.GetComponent<CameraFollow>().distance = new Vector3(-0.2f, 0.24f, -1.5f);
    }

    public static void StartSingle() {
        SceneManager.LoadScene("SingleScene");
    }

    public static void StartMulti() {
        SceneManager.LoadScene("MultiScene");
    }


}
