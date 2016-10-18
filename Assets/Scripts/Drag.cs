using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour
{
    Transform box;
    public KeyCode KeyToPress = KeyCode.E;
    float distance = 0;
    public float distanceFromObject = 10;
    public float heightOfTheGround = 0.5f;
    public float lowToGround = 0.5f;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(0.5f, 0.5f, 1));

            RaycastHit hit;
            //checks to see if you are clicking on an object
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "box")
                {
                    if (distance < distanceFromObject)
                    {
                        box = hit.transform;
                        box.parent = transform;
                    }
                }

            }
        }
        if(Input.GetKeyUp(KeyToPress))
        {
           box.parent = null;
        }
    }
}