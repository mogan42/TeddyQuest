using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class KeyGrabS : MonoBehaviour {

    public GameObject player;
    public string sceneName;
    public KeyCode KeyToPress = KeyCode.E;

    void OnTriggerStay(Collider d)
    {
        playerProgress giveOldKey = player.GetComponent<playerProgress>();
        if (d.tag == "Player" && Input.GetKeyDown(KeyToPress))
        {
            giveOldKey.numberOfKeys++;
            giveOldKey.SaveProgress();
            SceneManager.LoadScene(sceneName);
        }
    }
}
