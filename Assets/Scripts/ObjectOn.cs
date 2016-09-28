using UnityEngine;
using System.Collections;

public class ObjectOn : MonoBehaviour {

    public GameObject Object1;
    bool objectToggle;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            objectToggle = !objectToggle;
            Object1.SetActive(objectToggle);
        }
    }
}
