using UnityEngine;
using System.Collections;

public class CaveRoom2 : MonoBehaviour
{
    public GameObject On;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            On.SetActive(true);
        }
    }
}
