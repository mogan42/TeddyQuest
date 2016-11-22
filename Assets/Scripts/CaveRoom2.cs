using UnityEngine;
using System.Collections;

public class CaveRoom2 : MonoBehaviour
{
    public GameObject On;
    public GameObject Off;
    private int audioCounter = 0;
    public AudioSource sound;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            On.SetActive(true);
            Off.SetActive(false);
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

