using UnityEngine;
using System.Collections;

public class LevelExits : MonoBehaviour {
    public GameObject caveLevel;
    public GameObject vegForest;
    public GameObject amazonLibrary;
    public GameObject childsRoom;

    private GameObject levelEntrancePoint;
    public GameObject globalController;
    // Use this for initialization
    void Start()
    {

    }

    /*if (levelEntrancePoint.vegForestExit == true)
         {
         Debug.Log("second level down");
         caveLevel.SetActive(false);
         vegForest.SetActive(true);
         amazonLibrary.SetActive(false);
         childsRoom.SetActive(false);
         }

     if (levelEntrancePoint.amazonLibraryExit == true)
         {
         Debug.Log("Thrid level down");
         caveLevel.SetActive(false);
         vegForest.SetActive(false);
         amazonLibrary.SetActive(true);
         childsRoom.SetActive(false);
         }

     if (levelEntrancePoint.childsRoomExit == true)
         {
         Debug.Log("Forth level down");
         caveLevel.SetActive(false);
         vegForest.SetActive(false);
         amazonLibrary.SetActive(false);
         childsRoom.SetActive(true);
         }*/

    // Update is called once per frame
    void Update()
    {

        GlobalLog levelEntrancePoint = globalController.GetComponent<GlobalLog>();
        //levelEntrancePoint = GameObject.Find("GlobalLogObject").GetComponent<GlobalLog>();
        //{
            //Debug.Log("ahhhh");
            if (levelEntrancePoint.caveExit == true)
            {
                Debug.Log("First level down");
                caveLevel.SetActive(true);
                vegForest.SetActive(false);
                amazonLibrary.SetActive(false);
                childsRoom.SetActive(false);

                if (levelEntrancePoint.vegForestExit == true)
                {
                    Debug.Log("second level down");
                    caveLevel.SetActive(false);
                    vegForest.SetActive(true);
                    amazonLibrary.SetActive(false);
                    childsRoom.SetActive(false);

                    if (levelEntrancePoint.amazonLibraryExit == true)
                    {
                        Debug.Log("Thrid level down");
                        caveLevel.SetActive(false);
                        vegForest.SetActive(false);
                        amazonLibrary.SetActive(true);
                        childsRoom.SetActive(false);

                        if (levelEntrancePoint.childsRoomExit == true)
                        {
                            Debug.Log("Forth level down");
                            caveLevel.SetActive(false);
                            vegForest.SetActive(false);
                            amazonLibrary.SetActive(false);
                            childsRoom.SetActive(true);
                        }

                    }

                }

            }

        //}
    }

}
