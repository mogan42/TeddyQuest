using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour
{
    public GameObject but1, but2, but3, but4, but5, but6, but7, but8, but9, but0, /*You dont have to have the next 2 but i thought i would make it easier*/butCE, butEnter;
    public string curPassword = "123";
    string input;
    // Use this for initialization
    void Start ()
    {
        input = "";

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //checks to see if you are clicking on an object
            if (Physics.Raycast(ray, out hit))
            {
                //if the object hit is the one that you assigned as button 1 then add 1 to the answer
                if (hit.transform.gameObject == but1)
                {

                    input += "1";
                }
                else if (hit.transform.gameObject == but2)
                {
                    input += "2";
                }
                else if(hit.transform.gameObject == but3)
                {
                    input += "3";
                }
                else if (hit.transform.gameObject == but4)
                {
                    input += "4";
                }
                else if (hit.transform.gameObject == but5)
                {
                    input += "5";
                }
                else if (hit.transform.gameObject == but6)
                {
                    input += "6";
                }
                else if (hit.transform.gameObject == but7)
                {
                    input += "7";
                }
                else if (hit.transform.gameObject == but8)
                {
                    input += "8";
                }
                else if (hit.transform.gameObject == but9)
                {
                    input += "9";
                }
                else if (hit.transform.gameObject == but0)
                {
                    input += "0";
                }
                //clears input if clear is pressed
                else if (hit.transform.gameObject == butCE)
                {
                    input = "";
                }
                if (hit.transform.gameObject == butEnter)
                {
                    if (input == curPassword)
                    {
                        // this is an example of the text change.
                        input = "you have it right!";
                        //do shit when they ahve the right answer..
                    }
                }
            }
            
        }
	}
    void OnGUI()
    {
        GUI.Box(new Rect(5, 5, 310, 25), input);
    }
}
