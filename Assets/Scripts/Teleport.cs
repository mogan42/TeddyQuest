using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public Transform teleportSpot;

    void OnTriggerEnter(Collider collided)
    {
        if ( collided.tag == "Player")
        {
            collided.transform.position = teleportSpot.position;
            collided.transform.rotation = teleportSpot.rotation;
        }
    }
}
