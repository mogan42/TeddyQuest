using UnityEngine;
using System.Collections;

public class KeyGrabS : MonoBehaviour {

    public GameObject door;
    public KeyCode KeyToPress = KeyCode.E;

    void OnTriggerStay(Collider d)
    {
        if (d.tag == "Player" && Input.GetKeyDown(KeyToPress))
        {
            door.SetActive(true);
            Destroy(gameObject);
        }
    }
}
