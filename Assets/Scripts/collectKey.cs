using UnityEngine;
using System.Collections;

public class collectKey : MonoBehaviour {

    public int keysToGive;
    public GameObject player;

    // Use this for initialization
    void OnTriggerEnter(Collider collided)
    {
        if (collided.tag == ("Player"))
        {
            KeyLog giveKey = player.GetComponent<KeyLog>();
            giveKey.numberOfLevelKeys = keysToGive;
            Destroy(gameObject);
        }
    }

}
