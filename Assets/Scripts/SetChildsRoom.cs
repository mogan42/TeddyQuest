using UnityEngine;
using System.Collections;

public class SetChildsRoom : MonoBehaviour {

    public GameObject player;

    void OnTriggerEnter(Collider collided)
    {
        if (collided.tag == "Player")
        {
            //Debug.Log("this works!");
            playerProgress test = player.GetComponent<playerProgress>();
            test.childsRoomExit = true;
        }

    }

}
