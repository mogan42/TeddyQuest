using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInteration : MonoBehaviour
{
    public Text interactKey;
    public float visionWidth = 20f;
    public float visionLength = 10f;
    public KeyCode Button = KeyCode.Q;
    public float Force = 10.0f;


<<<<<<< HEAD
    private GameObject movableObject;
=======

    void Start()
    {
        //interactKey.enabled = false;
    }
>>>>>>> f72f443ac2513d93b84079114b8d1cfc981a0b9e


    void Update()
    {
        var movableObjects = GameObject.FindGameObjectsWithTag("movable");
        foreach (GameObject mo in movableObjects)
        {
            Vector3 direction = mo.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.up);
            Debug.Log(angle);
            if(angle < visionWidth * 0.5f)
            {
                RaycastHit hit;

                if (Physics.Raycast(transform.position, direction.normalized, out hit, visionLength))
                {
                    if (hit.collider.gameObject == mo)
                    {
                        Debug.DrawRay(transform.position, direction.normalized, Color.green);
                        interactKey.gameObject.SetActive(true);
                        if(Input.GetKey(Button))
                        {
                            hit.rigidbody.AddForceAtPosition(Force * direction, hit.point);

                        }
                    }
                }
            }
            if(angle > visionWidth * 0.5f)
            {
                     interactKey.gameObject.SetActive(false);
            }
        }
    }

}
