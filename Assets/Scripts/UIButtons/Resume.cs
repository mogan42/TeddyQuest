using UnityEngine;
using System.Collections;

public class Resume : MonoBehaviour {
    public void resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        transform.gameObject.SetActive(false);
        Debug.Log("Locked cursor");
    }
}
