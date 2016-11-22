using UnityEngine;
using System.Collections;
using InControl;


public class TwoButtons : MonoBehaviour
{
    public GameObject button1, button2, itemToRemove;
    public KeyCode KeyToPress = KeyCode.E;
    private int buttonsPressed;
    private bool button1Pressed, button2Pressed;
    public AudioSource sound;
    private int audioCounter = 0;

    void Start ()
    {
        buttonsPressed = 0;
        button1Pressed = false;
        button2Pressed = false;
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        var inputDevice = InputManager.ActiveDevice;

        if (Input.GetKeyDown(KeyToPress) || inputDevice.RightTrigger)
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

                }
                else if (hit.transform.gameObject == button2 && button2Pressed == false)
                {
                    buttonsPressed++;
                    button2Pressed = true;
                    button2.gameObject.layer = LayerMask.NameToLayer("Default");
                }
            }
        }
        if (buttonsPressed == 2)
        {
            if(audioCounter == 0)
            {
                audioCounter = audioCounter + 1;
            }
            

            if(audioCounter == 1)
            {
                SoundPlay();
                itemToRemove.SetActive(false);
                audioCounter = 2;
            }
           
        }
    }

    void SoundPlay()
    {
        sound.Play();
    }
}
