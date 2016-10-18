using UnityEngine;
using System.Collections;

public class HallwaySwitch : MonoBehaviour {

    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;
    public GameObject triggerOff;

    void OnTriggerEnter(Collider other)
    {
        Object1.SetActive(true);
        Object2.SetActive(true);
        Object3.SetActive(false);
        Object4.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        triggerOff.SetActive(false);
    }
}
