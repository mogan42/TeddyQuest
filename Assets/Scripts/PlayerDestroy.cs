using UnityEngine;
using System.Collections;

public class PlayerDestroy : MonoBehaviour {

    public GameObject player;

void OnTriggerEnter(Collider collided)
    {
        if(player.tag == ("Player"))
        {
            Destroy(gameObject);
        }
    }
}
