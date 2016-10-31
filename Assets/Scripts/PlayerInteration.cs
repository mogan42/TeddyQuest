using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInteration : MonoBehaviour
{
    public Text interactKey;
    public KeyCode interactButton = KeyCode.E;
    public float maxPickUpDistance = 5.0f;

    private bool canInteract = false;


    void Start()
    {
        interactKey.enabled = false;
    }


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "movable")
        {
            DistanceCheck();
            if (canInteract == true)
            {
                interactKey.enabled = true;
                if (Input.GetKey(interactButton))
                {

                }
            }
        }
        //else interactKey.enabled = false;       
    }

    void OnTriggerExit()
    {
        if(gameObject.tag == "movable")
        {
            interactKey.enabled = false;
        }
    }

    void DistanceCheck()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, maxPickUpDistance))
        {
            if(hit.distance <= maxPickUpDistance)
            {
                if(hit.collider.gameObject.tag == "movable")
                {
                    canInteract = true;
                    Debug.DrawRay(transform.position + transform.up, hit.transform.position, Color.green);
                }
                else
                {
                    canInteract = false;
                }
            }
            else
            {
                canInteract = false;
            }
        }
        else
        {
            canInteract = false;
        }
    }

}
