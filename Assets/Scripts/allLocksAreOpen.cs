using UnityEngine;
using System.Collections;

public class allLocksAreOpen : MonoBehaviour {

    public Animator blockAnim;
    public GameObject player;

    void OnTriggerStay(Collider collided)
    {
        KeyLog hasAllKeys = player.GetComponent<KeyLog>();
        if (hasAllKeys.hasBlueKey && hasAllKeys.hasGreenKey && hasAllKeys.hasRedKey && hasAllKeys.hasYellowKey)
        {
            blockAnim.SetTrigger("MoveBlocks");
        }
    }
}
