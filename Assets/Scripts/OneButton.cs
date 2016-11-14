using UnityEngine;
using System.Collections;

public class OneButton : MonoBehaviour
{
    public GameObject button1;
    public KeyCode KeyToPress = KeyCode.E;
    private int buttonsPressed;
    // Morgans edit (was getting errors so I fixed them)|| could not get it working so im comenting it out.
    public Animator childsExitDoor;
    public Animator doorSwitch;
    void Start()
    {
        buttonsPressed = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 1));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject == button1)
                {
                    buttonsPressed++;
                    button1.gameObject.layer = LayerMask.NameToLayer("Default");
                    //added animation
                    doorSwitch.SetTrigger("PulledSwitch");
                }

            }
        }

        if (buttonsPressed == 1)
        
        {
            childsExitDoor.SetTrigger("SwitchIsToggled");

        } 
    }
}
        
