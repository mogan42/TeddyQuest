//using UnityEngine;
//using System.Collections;

//public class DragV2 : MonoBehaviour
//{
//    public GameObject player;
//    public float heightOfTheGround = 0.5f;
//    public float lowToGround = 0.5f;
//    // Use this for initialization
//    void Start ()
//    {
	
//	}

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//            RaycastHit hit;
//            //checks to see if you are clicking on an object
//            if (Physics.Raycast(ray, out hit))
//            {
//                if (hit.transform.tag == "box")
//                {
//                    hit.transform.parent = player;
//                    if (hit.transform.position.y > heightOfTheGround)
//                    {
//                        hit.transform.position = new Vector3(hit.transform.position.x, heightOfTheGround - 0.001f, hit.transform.position.z);
//                    }
//                    if (hit.transform.position.y < lowToGround)
//                    {
//                        hit.transform.position = new Vector3(hit.transform.position.x, lowToGround + 0.001f, hit.transform.position.z);
//                    }
//                }

//            }
//        }
//    }
//}


//original VVVV


//using UnityEngine;
//using System.Collections;


//public class Drag : MonoBehaviour
//{
//    public Transform other;
//    float distance;
//    public float distanceFromObject = 10;
//    public float heightOfTheGround = 0.5f;
//    public float lowToGround = 0.5f;
//    void OnMouseDown()
//    {
//        distance = Vector3.Distance(transform.position, other.transform.position);
//    }

//    void OnMouseDrag()
//    {
//        if (distance < distanceFromObject)
//        {
//            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
//            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
//            Vector3 playerToObject = objPosition - other.transform.position;
//            playerToObject.Normalize();
//            playerToObject *= distance;
//            transform.position = other.transform.position + playerToObject;
//            if (transform.position.y > heightOfTheGround)
//            {
//                transform.position = new Vector3(transform.position.x, heightOfTheGround - 0.001f, transform.position.z);
//            }
//            if (transform.position.y < lowToGround)
//            {
//                transform.position = new Vector3(transform.position.x, lowToGround + 0.001f, transform.position.z);
//            }
//        }

//    }
//}

