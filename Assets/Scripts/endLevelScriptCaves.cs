using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class endLevelScriptCaves : MonoBehaviour {

    public GameObject player;
    public string sceneName;

    void OnTriggerEnter(Collider collided) {

        playerProgress giveOldKey = player.GetComponent<playerProgress>();
        giveOldKey.numberOfKeys++;
        giveOldKey.caveExit = true;
        if (collided.tag == ("Player"))
        {
            giveOldKey.SaveProgress();
            SceneManager.LoadScene(sceneName);
        }

    } 
}
