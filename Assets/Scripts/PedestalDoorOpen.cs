using UnityEngine;
using System.Collections;

public class PedestalDoorOpen : MonoBehaviour
{
    //public float openingSpeed = 10.0f;
    private int pedestalActiveCount;
    public GameObject pedestalDoor;
    private int audioCounter = 0;
    public AudioSource sound;

    // public Animator openZeDoor;

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
            pedestalDoor.SetActive(true);
            if (audioCounter == 0)
            {
                audioCounter = audioCounter + 1;
            }
            if (audioCounter == 1)
            {
                SoundPlay();
                audioCounter = 2;
            }

        }
    }
    void SoundPlay()
    {
        //44100 = 1 second delay // 22050 = .5 second delay
        sound.Play(44100);
    }
}
