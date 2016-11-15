using UnityEngine;
using System.Collections;

public class PedestalDoorOpen : MonoBehaviour
{
    public float openingSpeed = 10.0f;
    private int pedestalActiveCount;
    public GameObject pedestalDoor;

    // Use this for initialization
    void Start ()
    {
        pedestalActiveCount = 0;
    }


    public void CountIncrease()
    {
        pedestalActiveCount = pedestalActiveCount + 1;
        Debug.Log(pedestalActiveCount);
    }

    void Update()
    {
        if(pedestalActiveCount >= 5)
        {
            //  pedestalDoor.SetActive(false);

        }
    }

}
