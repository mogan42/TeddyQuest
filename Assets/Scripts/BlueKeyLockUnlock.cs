using UnityEngine;
using System.Collections;

public class BlueKeyLockUnlock : MonoBehaviour {

    public GameObject player;
    public Animator lockAnim;
    public KeyCode KeyToPress = KeyCode.E;


    void OnTriggerEnter(Collider collided)
    {
        KeyLog hasRightKey = player.GetComponent<KeyLog>();
        Debug.Log("GetComponent");
          if (Input.GetKeyDown(KeyToPress) && hasRightKey.hasBlueKey == true)
           {
            Debug.Log("play animation");
                lockAnim.SetTrigger("Unlock");
           }

       } 

}
