
using UnityEngine;
using System.Collections;


public class DragV2 : MonoBehaviour
{
    public GameObject other;
    float distance;
    public float distanceFromObject = 10;
    public float heightOfTheGround = 6.5f;
    public float lowToGround = 0.2f;
    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, other.transform.position);
    }

    void OnMouseDrag()
    {
        if (distance < distanceFromObject)
        {
            int x = Screen.width / 2;
            int y = Screen.width / 2;
            Vector3 mousePosition = new Vector3(x, y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector3 playerToObject = objPosition - other.transform.position;
            playerToObject.Normalize();
            playerToObject *= distance;
            transform.position = other.transform.position + playerToObject;
           // other.gameObject.GetComponent<Rigidbody>().useGravity = false;
            if (transform.position.y > heightOfTheGround)
            {
                transform.position = new Vector3(transform.position.x, heightOfTheGround - 0.001f, transform.position.z);
            }
            if (transform.position.y < lowToGround)
            {
                transform.position = new Vector3(transform.position.x, lowToGround + 0.001f, transform.position.z);
            }
        }

    }
}

