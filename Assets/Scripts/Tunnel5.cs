using UnityEngine;
using System.Collections;

public class Tunnel5 : MonoBehaviour {

    public GameObject On;
    public GameObject Off;

    void OnTriggerEnter(Collider other)
    {
        On.SetActive(true);
        Off.SetActive(false);
    }
}
