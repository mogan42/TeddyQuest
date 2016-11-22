using UnityEngine;
using System.Collections;

public class CaveObjectPickup : MonoBehaviour {

    public KeyCode KeyToPress = KeyCode.E;
    public GameObject Key;
    private int audioCounter = 0;
    public AudioSource sound;
    public Animator doors;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            Key.SetActive(false);
            doors.SetTrigger("openDoors");
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
