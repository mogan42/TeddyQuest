using UnityEngine;
using System.Collections;

public class DragToggle : MonoBehaviour
{
    Transform box;
    public KeyCode KeyToPress = KeyCode.E;
    float distance = 0;
    public float distanceFromObject = 10;
    public float heightOfTheGround = 0.5f;
    public float lowToGround = 0.5f;
    bool itemPicked;
    public string nameOfTag = "box";
    // Use this for initialization
    void Start()
    {
        itemPicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            if (itemPicked == false)
            {
                Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 1));

                RaycastHit hit;
                //checks to see if you are clicking on an object
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.tag == nameOfTag)
                    {
                        distance = Vector3.Distance(transform.position, hit.transform.position);
                        
                        if (distance < distanceFromObject)
                        {
                            box = hit.transform;
                            box.parent = transform;
                            itemPicked = true;
                        }
                    }

               } 
            }
            else if(itemPicked == true)
            {
                box.parent = null;
                itemPicked = false;
            }
           
        }
    }
}