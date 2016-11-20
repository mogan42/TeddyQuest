using UnityEngine;
using System.Collections;

public class BlueKeyLockUnlock : MonoBehaviour {

    public GameObject player;
    public Animator lockAnim;


    void OnTriggerEnter(Collider collided)
    {
        KeyLog hasRightKey = player.GetComponent<KeyLog>();
        if (player.tag == ("Player"))
        {
            if (hasRightKey.hasBlueKey == true)
            {
                lockAnim.SetTrigger("Unlock");
            }
        }
    } 

}
