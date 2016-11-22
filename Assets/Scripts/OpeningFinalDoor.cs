using UnityEngine;
using System.Collections;

public class OpeningFinalDoor : MonoBehaviour
{

    public GlobalLog globalLog;
    //public GameObject Lock1, Lock2, Lock3, Door;

    public Animator padLock1, padLock2, padLock3, finalDoor;

	void OnTriggerEnter(Collider collided)
    {
        int keys = globalLog.numberOfKeys;
        bool lock1 = globalLog.lock1Open, lock2 = globalLog.lock2Open, lock3 = globalLog.lock3Open;

        if (keys > 0 &! lock1)
        {
            //play animation for unlocking the door.
            //use Lock 1 for that lock if needed.
            lock1 = true;
            padLock1.SetTrigger("FinalDoorUnlock");
        }
        if (keys >1 &! lock2)
        {
            //play animation for unlocking the door.
            //use Lock 2 for that lock if needed.

            lock2 = true;
            padLock2.SetTrigger("FinalDoorUnlock");
        }
        if (keys >2 & !lock3)
        {
            //play animation for unlocking the door.
            //use Lock 3 for that lock if needed.
            padLock3.SetTrigger("FinalDoorUnlock");
            lock3 = true;
            
        }
        if (lock3)
        {
            //play animation for door opening.
            //use Door for animation if needed.
            finalDoor.SetTrigger("FinalDoorUnlock");
        }
    }
}
