using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadSence : MonoBehaviour {

    public string sceneName;

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(sceneName);
    }

}
