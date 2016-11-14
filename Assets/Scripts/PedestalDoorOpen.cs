using UnityEngine;
using System.Collections;

public class PedestalDoorOpen : MonoBehaviour
{
    private int pedestalActiveCount;
    public GameObject pedestalDoor;

    // Use this for initialization
    void Start ()
    {
        pedestalActiveCount = 0;
    }


    void CountIncrease()
    {
        pedestalActiveCount = pedestalActiveCount + 1;
    }

    void Update()
    {
        if(pedestalActiveCount >= 5)
        {
            pedestalDoor.SetActive(false);
        }
    }

}
