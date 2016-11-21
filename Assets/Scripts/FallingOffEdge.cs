using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class FallingOffEdge : MonoBehaviour {

    void OnTriggerEnter()
    {
        Scene current = SceneManager.GetActiveScene();
        SceneManager.LoadScene(current.name);
    }
}
