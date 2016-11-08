using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public Text interactKey;
    public float visionWidth = 20f;
    public float visionLength = 10f;
    public KeyCode Button = KeyCode.Q;
    public float Force = 10.0f;
    private float lowestAngle = 100;
    private GameObject closestMoveable;



    private GameObject movableObject;

    //void Start()
    //{
    //    //interactKey.enabled = false;
    //}



    void Update()
    {
        var movableObjects = GameObject.FindGameObjectsWithTag("movable");
        //GameObject.FindObjectsOfType<ITorchInteractable>();
        lowestAngle = 100;
        foreach (GameObject mo in movableObjects)
        {
            Vector3 direction = mo.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.up);
            Debug.Log(angle);
            Debug.Log("lowest Angle" + lowestAngle);
            if (angle < lowestAngle)
            {
                lowestAngle = angle;
                closestMoveable = mo; 
            }
        }

        Vector3 direction2 = closestMoveable.transform.position - transform.position;
        float A = Vector3.Angle(direction2, transform.up);
        Debug.Log(closestMoveable);
         if (A < visionWidth * 0.5f)
         {
            RaycastHit hit;

            if(Physics.Raycast(transform.position, direction2.normalized, out hit, visionLength))
            {
                if (hit.collider.gameObject == closestMoveable)
                {
                    Debug.DrawRay(transform.position, direction2.normalized, Color.green);
                    interactKey.gameObject.SetActive(true);
                    if(Input.GetKey(Button))
                    {
                        hit.rigidbody.AddForceAtPosition(Force * direction2, hit.point);
                    }
                }
             }
         }
        if (A > visionWidth * 0.5f)
        {
            interactKey.gameObject.SetActive(false);
        }
     
    }
}
    



   //if(angle > visionLength* 0.5f)
   //     {
   //         interactKey.gameObject.SetActive(false);
   //     }