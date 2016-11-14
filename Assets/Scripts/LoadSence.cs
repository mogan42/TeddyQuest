using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadSence : MonoBehaviour {

    public GameObject player;

    public string sceneName;

    void OnTriggerEnter()
    {
        playerProgress runSaveProgress = player.GetComponent<playerProgress>();
        runSaveProgress.SaveProgress();
        SceneManager.LoadScene(sceneName);
    }

}
