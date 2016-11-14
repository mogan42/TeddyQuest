using UnityEngine;
using System.Collections;

public class ResetExitsTrigger : MonoBehaviour {

    public GameObject player;

    void OnTriggerEnter(Collider Collided)
    {
        /*if (Collided.tag == "Player")
        {
            playerProgress reset = player.GetComponent<playerProgress>();
            reset.caveExit = false;
            reset.childsRoomExit = false;
            reset.amazonLibraryExit = false;
            reset.vegForestExit = false;
            Debug.Log("this works");
        }*/
    }
}
