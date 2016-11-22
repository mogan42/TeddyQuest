using UnityEngine;
using System.Collections;

public class playerProgress : MonoBehaviour {

    public bool caveExit;
    public bool vegForestExit;
    public bool amazonLibraryExit;
    public bool childsRoomExit;

    public int numberOfKeys;

    public bool lock1Open = false, lock2Open = false, lock3Open = false;

    // loading data from GlobalLog
    void Start () {

        caveExit = GlobalLog.Instance.caveExit;
        vegForestExit = GlobalLog.Instance.vegForestExit;
        amazonLibraryExit = GlobalLog.Instance.amazonLibraryExit;
        childsRoomExit = GlobalLog.Instance.childsRoomExit;
        numberOfKeys = GlobalLog.Instance.numberOfKeys;

    }
	
    //saving changes to GlobalLog 
    public void SaveProgress()
    {
        GlobalLog.Instance.caveExit = caveExit;
        GlobalLog.Instance.vegForestExit = vegForestExit;
        GlobalLog.Instance.amazonLibraryExit = amazonLibraryExit;
        GlobalLog.Instance.childsRoomExit = childsRoomExit;
        GlobalLog.Instance.numberOfKeys = numberOfKeys;
    }
}
