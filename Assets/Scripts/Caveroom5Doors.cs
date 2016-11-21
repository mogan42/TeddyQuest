using UnityEngine;
using System.Collections;

public class Caveroom5Doors : MonoBehaviour {

    public KeyCode KeyToPress = KeyCode.E;
    public GameObject Key;

    public Animator doors;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            Key.SetActive(false);
            doors.SetTrigger("openDoors");

        }
    }
}
