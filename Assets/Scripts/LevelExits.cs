using UnityEngine;
using System.Collections;

public class LevelExits : MonoBehaviour {
    public GameObject caveLevel;
    public GameObject vegForest;
    public GameObject amazonLibrary;
    public GameObject childsRoom;

    public GameObject globalController;

	// Use this for initialization
	void Start () {
        GlobalLog levelEntrancePoint = globalController.GetComponent<GlobalLog>();
        //Debug.Log("ahhhh");
	    if (levelEntrancePoint.caveExit == true)
            {
            caveLevel.SetActive(true);
            vegForest.SetActive(false);
            amazonLibrary.SetActive(false);
            childsRoom.SetActive(false);
            }

        else if (levelEntrancePoint.vegForestExit == true)
            {
            caveLevel.SetActive(false);
            vegForest.SetActive(true);
            amazonLibrary.SetActive(false);
            childsRoom.SetActive(false);
            }

        else if (levelEntrancePoint.amazonLibraryExit == true)
            {
            caveLevel.SetActive(false);
            vegForest.SetActive(false);
            amazonLibrary.SetActive(true);
            childsRoom.SetActive(false);
            }

        else if (levelEntrancePoint.childsRoomExit == true)
            {
            Debug.Log("this works");
            caveLevel.SetActive(false);
            vegForest.SetActive(false);
            amazonLibrary.SetActive(false);
            childsRoom.SetActive(true);
            }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
