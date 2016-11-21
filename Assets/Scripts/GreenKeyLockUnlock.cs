using UnityEngine;
using System.Collections;

public class GreenKeyLockUnlock : MonoBehaviour {

    public GameObject player;
    public Animator lockAnim;
    public KeyCode KeyToPress = KeyCode.E;


    void OnTriggerStay(Collider collided)
    {
        KeyLog hasRightKey = player.GetComponent<KeyLog>();
        //Debug.Log(hasRightKey.hasBlueKey);
          if (Input.GetKeyDown(KeyToPress) && hasRightKey.hasGreenKey)
           {
            //Debug.Log("play animation");
                lockAnim.SetTrigger("Unlock");
           }

       } 

}
