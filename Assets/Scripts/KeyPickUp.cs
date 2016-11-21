using UnityEngine;
using System.Collections;

public class KeyPickUp : MonoBehaviour
{
    public GameObject key, padlock;

    //public CollectedKeyCounter CKC;

    void OnTriggerEnter(Collider other)
    {
        Destroy(key);
        Destroy(padlock);
    }
}