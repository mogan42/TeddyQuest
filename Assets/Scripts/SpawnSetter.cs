using UnityEngine;
using System.Collections;

public class SpawnSetter : MonoBehaviour
{
    public GameObject Spawnpoint;
 
    void OnTriggerEnter(Collider other)
    {
        Spawnpoint.transform.position = other.transform.position;
    }
}
