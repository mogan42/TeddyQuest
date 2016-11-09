using UnityEngine;
using System.Collections;

public class BabyButton : MonoBehaviour
{
    public GameObject button1, button2, button3, ClickedButton1, ClickedButton2, ClickedButton3;
    public string password = "123";
    string input;
    int amountOfButtonsPressed;
    public float restartCooldown = 2.0f;
    public KeyCode KeyToPress = KeyCode.E;
    private float timer = 0;
    private bool correct = false;
    //Animation Stuff
    public Animator animator;
    //Audio stuff
    //public AudioSource door;
    //public AudioClip doorMoving;
    // Use this for initialization
    void Start ()
    {
        input = "";
        amountOfButtonsPressed = 0;
        timer = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetKeyDown(KeyToPress))
        {
            //Debug.Log("made it");
            if (Physics.Raycast(ray, out hit))
            {
                //Debug.Log(hit.collider.gameObject.name);
                //Debug.DrawRay(transform.position,Vector3.forward, Color.green);
                if(hit.transform.gameObject == button1)
                {
                    input += "1";
                    ClickedButton1.transform.position = button1.transform.position;
                    button1.SetActive(false);
                    ClickedButton1.SetActive(true);
                    //Debug.Log("hit 1");
                    timer = restartCooldown;
                    amountOfButtonsPressed++;
                }
                else if (hit.transform.gameObject == button2)
                {
                    input += "2";
                    ClickedButton2.transform.position = button2.transform.position;
                    button2.SetActive(false);
                    ClickedButton2.SetActive(true);
                    //Debug.Log("hit 2");
                    timer = restartCooldown;
                    amountOfButtonsPressed++;
                }
                else if (hit.transform.gameObject == button3)
                {
                    input += "3";
                    ClickedButton3.transform.position = button3.transform.position;
                    button3.SetActive(false);
                    ClickedButton3.SetActive(true);
                    //Debug.Log("hit 3");
                    amountOfButtonsPressed++;
                    timer = restartCooldown;
                }
            }
        }
        timer -= Time.deltaTime;
        if (input == password)
        {
            correct = true;
        }
        if (timer <= 0)
        {
            if (amountOfButtonsPressed == 3 && !correct)
            {
                input = "";
                amountOfButtonsPressed = 0;
                button1.SetActive(true);
                ClickedButton1.SetActive(false);
                button2.SetActive(true);
                ClickedButton2.SetActive(false);
                button3.SetActive(true);
                ClickedButton3.SetActive(false);
            }
        }
        if(correct)
        {
            //do the thing you wanted it to do.
            //animating door
            animator.SetTrigger("moveDoor");
            //giving the door sound
            //door.PlayOneShot(doorMoving, 0.7f);
            //Debug.Log("I'm working");
        }

    }
}
