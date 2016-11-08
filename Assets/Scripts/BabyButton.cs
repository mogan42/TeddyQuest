using UnityEngine;
using System.Collections;

public class BabyButton : MonoBehaviour
{
    public GameObject button1, button2, button3, ClickedButton1, ClickedButton2, ClickedButton3;
    public string password = "123";
    string input;
    public KeyCode KeyToPress = KeyCode.E; 
    // Use this for initialization
    void Start ()
    {
        input = "";
	}
	
	// Update is called once per frame
	void Update ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetKeyDown(KeyToPress))
        {
            Debug.Log("made it");
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                Debug.DrawRay(transform.position,Vector3.forward, Color.green);
                if(hit.transform.gameObject == button1)
                {
                    input += "1";
                    ClickedButton1.transform.position = button1.transform.position;
                    button1.SetActive(false);
                    ClickedButton1.SetActive(true);
                    Debug.Log("hit 1");
                }
                else if (hit.transform.gameObject == button2)
                {
                    input += "2";
                    ClickedButton2.transform.position = button2.transform.position;
                    button2.SetActive(false);
                    ClickedButton2.SetActive(true);
                    Debug.Log("hit 2");
                }
                else if (hit.transform.gameObject == button3)
                {
                    input += "3";
                    ClickedButton3.transform.position = button3.transform.position;
                    button3.SetActive(false);
                    ClickedButton3.SetActive(true);
                    Debug.Log("hit 3");
                }
                if (hit.transform.gameObject == ClickedButton1)
                {
                    button1.SetActive(true);
                    ClickedButton1.SetActive(false);
                }
                else if (hit.transform.gameObject == ClickedButton2)
                {
                    button2.SetActive(true);
                    ClickedButton2.SetActive(false);
                }
                else if (hit.transform.gameObject == ClickedButton3)
                {
                    button3.SetActive(true);
                    ClickedButton3.SetActive(false);
                }
                if (input == password)
                {
                    //do the thing you wanted it to do.
                }
            }
        }
    }
}
