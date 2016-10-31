using UnityEngine;
using System.Collections;

public class CaveRoom2 : MonoBehaviour
{
    public GameObject On;
    public GameObject Off;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            On.SetActive(true);
            Off.SetActive(false);
        }
    }
}
