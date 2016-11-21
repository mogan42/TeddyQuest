using UnityEngine;
using System.Collections;

public class OpeningFinalDoor : MonoBehaviour
{

    public GlobalLog globalLog;
    public GameObject Lock1, Lock2, Lock3, Door;
	void OnCollisionEnter()
    {
        int keys = globalLog.numberOfKeys;
        bool lock1 = globalLog.lock1Open, lock2 = globalLog.lock2Open, lock3 = globalLog.lock3Open;

        if (keys > 0 &! lock1)
        {
            //play animation for unlocking the door.
            //use Lock 1 for that lock if needed.
            lock1 = true;
        }
        if (keys >1 &! lock2)
        {
            //play animation for unlocking the door.
            //use Lock 2 for that lock if needed.

            lock2 = true;
        }
        if (keys >2 & !lock3)
        {
            //play animation for unlocking the door.
            //use Lock 3 for that lock if needed.

            lock3 = true;
        }
        if (lock3)
        {
            //play animation for door opening.
            //use Door for animation if needed.

        }
    }
}
