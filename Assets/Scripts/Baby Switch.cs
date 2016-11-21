using UnityEngine;
using System.Collections;
using InControl;


public class BabySwitch : MonoBehaviour
{
    public GameObject button1, itemToRemove;
    public KeyCode KeyToPress = KeyCode.E;
    // Use this for initialization
    void Start ()
    {
	
	}

    // Update is called once per frame
    void Update()
    {
        var inputDevice = InputManager.ActiveDevice;
        if (Input.GetKeyDown(KeyToPress) || inputDevice.RightTrigger)
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 1));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject == button1)
                {
                    itemToRemove.SetActive(false);
                    button1.gameObject.layer = LayerMask.NameToLayer("Default");
                }
            }
        }
    }
}
