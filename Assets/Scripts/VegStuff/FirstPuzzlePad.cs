using UnityEngine;
using System.Collections;

public class FirstPuzzlePad : MonoBehaviour {

    public GameObject button1, button2, button3, button4, button5, button6, button7, button8, 
        ClickedButton1, ClickedButton2, ClickedButton3, ClickedButton4, ClickedButton5, ClickedButton6, ClickedButton7, ClickedButton8;
    public string password = "123";
    string input;
    int amountOfButtonsPressed;
    public float restartCooldown = 2.0f;
    public KeyCode KeyToPress = KeyCode.E;
    private float timer = 0;
    private bool correct = false;
    //Animation Stuff
    public Animator babyButtons;
    //Audio stuff
    //public AudioSource door;
    //public AudioClip doorMoving;
    // Use this for initialization

    public GameObject cubeReal, pillar;

    void Start()
    {
        input = "";
        amountOfButtonsPressed = 0;
        timer = 0;
    }
    #region
    // Update is called once per frame
    void Update()
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
                if (hit.transform.gameObject == button1)
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
                else if (hit.transform.gameObject == button4)
                {
                    input += "4";
                    ClickedButton3.transform.position = button4.transform.position;
                    button4.SetActive(false);
                    ClickedButton4.SetActive(true);
                    //Debug.Log("hit 4");
                    amountOfButtonsPressed++;
                    timer = restartCooldown;
                }
                else if (hit.transform.gameObject == button5)
                {
                    input += "5";
                    ClickedButton5.transform.position = button5.transform.position;
                    button5.SetActive(false);
                    ClickedButton5.SetActive(true);
                    //Debug.Log("hit 5");
                    amountOfButtonsPressed++;
                    timer = restartCooldown;
                }
                else if (hit.transform.gameObject == button6)
                {
                    input += "6";
                    ClickedButton6.transform.position = button6.transform.position;
                    button6.SetActive(false);
                    ClickedButton6.SetActive(true);
                    //Debug.Log("hit 6");
                    amountOfButtonsPressed++;
                    timer = restartCooldown;
                }
                else if (hit.transform.gameObject == button7)
                {
                    input += "7";
                    ClickedButton7.transform.position = button7.transform.position;
                    button7.SetActive(false);
                    ClickedButton7.SetActive(true);
                    //Debug.Log("hit 7");
                    amountOfButtonsPressed++;
                    timer = restartCooldown;
                }
                else if (hit.transform.gameObject == button8)
                {
                    input += "8";
                    ClickedButton8.transform.position = button8.transform.position;
                    button8.SetActive(false);
                    ClickedButton8.SetActive(true);
                    //Debug.Log("hit 8");
                    amountOfButtonsPressed++;
                    timer = restartCooldown;
                }
            }
        }
        #endregion
        timer -= Time.deltaTime;
        if (input == password)
        {
            correct = true;
        }
        if (timer <= 0)
        {
            if (amountOfButtonsPressed == 8 && !correct)
            {
                input = "";
                amountOfButtonsPressed = 0;
                button1.SetActive(true);
                ClickedButton1.SetActive(false);
                button2.SetActive(true);
                ClickedButton2.SetActive(false);
                button3.SetActive(true);
                ClickedButton3.SetActive(false);
                button4.SetActive(true);
                ClickedButton4.SetActive(false);
                button5.SetActive(true);
                ClickedButton5.SetActive(false);
                button6.SetActive(true);
                ClickedButton6.SetActive(false);
                button7.SetActive(true);
                ClickedButton7.SetActive(false);
                button8.SetActive(true);
                ClickedButton8.SetActive(false);
            }
        }
        if (correct)
        {
            pillar.SetActive(true);
            cubeReal.SetActive(true);
        }

    }
}
