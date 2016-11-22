using UnityEngine;
using System.Collections;
using InControl;

public class TwoButonsroom5 : MonoBehaviour {

    public GameObject but1, but2;
    public Animator Anim;
    public KeyCode KeyToPress = KeyCode.E;
    private int audioCounter = 0;
    public AudioSource sound;

    void OnTriggerStay(Collider other)
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 1));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject == but1 && Input.GetKeyDown(KeyToPress))
            {
                but1.SetActive(false);
                but2.SetActive(true);
                Anim.SetTrigger("cageOpen");
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
    }
    void SoundPlay()
    {
        //44100 = 1 second delay // 22050 = .5 second delay
        sound.Play(44100);
    }
}
