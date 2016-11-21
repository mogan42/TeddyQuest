using UnityEngine;
using System.Collections;

public class TeleportObj : MonoBehaviour {

    public Transform teleportSpot;

    void OnTriggerEnter(Collider collided)
    {
        if (collided.tag == ("box"))
        {
            collided.transform.position = teleportSpot.position;
            collided.transform.rotation = teleportSpot.rotation;
        }
    }
}
