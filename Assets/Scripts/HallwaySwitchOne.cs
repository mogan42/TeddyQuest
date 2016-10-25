using UnityEngine;
using System.Collections;

public class HallwaySwitchOne : MonoBehaviour {

    public GameObject Object_On;
    public GameObject Object_Off;
    public GameObject triggerOff;

    void OnTriggerEnter(Collider other)
    {
        Object_On.SetActive(true);
        Object_Off.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        triggerOff.SetActive(false);
    }
}
