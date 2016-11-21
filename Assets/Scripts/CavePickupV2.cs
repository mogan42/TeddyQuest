using UnityEngine;
using System.Collections;

public class CavePickupV2 : MonoBehaviour {

    public KeyCode KeyToPress = KeyCode.E;
    public GameObject ButtonOff;
    public GameObject ButtonOn;

    public Animator cage;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            ButtonOff.SetActive(false);
            ButtonOn.SetActive(true);
            cage.SetTrigger("cageOpen");
        }
    }
}
