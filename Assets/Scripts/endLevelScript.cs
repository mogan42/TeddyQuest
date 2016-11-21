using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class endLevelScript : MonoBehaviour {

    public GameObject player;
    public string sceneName;

    void OnTriggerEnter(Collider collided) {

        playerProgress giveOldKey = player.GetComponent<playerProgress>();
        giveOldKey.numberOfKeys++;
        if (collided.tag == ("Player"))
        {
            giveOldKey.SaveProgress();
            SceneManager.LoadScene(sceneName);
        }

    } 
}
