using UnityEngine;
using System.Collections;

public class TwoButtons : MonoBehaviour
{
    public GameObject button1, button2, itemToRemove;
    public KeyCode KeyToPress = KeyCode.E;
    private int buttonsPressed;
    private bool button1Pressed, button2Pressed;
    public AudioClip buttonSound;
    AudioSource audio;
    // Use this for initialization
    void Start ()
    {
        buttonsPressed = 0;
        button1Pressed = false;
        button2Pressed = false;
        audio = GetComponent<AudioSource>();
        audio.clip = buttonSound;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 1));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject == button1 && button1Pressed==false)
                {
                    buttonsPressed++;
                    button1Pressed = true;
                    button1.gameObject.layer = LayerMask.NameToLayer("Default");
                    audio.Play();
                }
                else if (hit.transform.gameObject == button2 && button2Pressed == false)
                {
                    buttonsPressed++;
                    button2Pressed = true;
                    button2.gameObject.layer = LayerMask.NameToLayer("Default");
                    audio.Play();
                }
            }
        }
        if (buttonsPressed == 2)
        {
            itemToRemove.SetActive(false);
        }
    }
}
