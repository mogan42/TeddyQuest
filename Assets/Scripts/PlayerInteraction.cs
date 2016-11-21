using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public Text interactKey;
    public float visionLength = 10f;
    private GameObject closestMoveable;
    public string LayerName = "Interact";

    // If this is changed make sure to change the canvas text
    public KeyCode Button = KeyCode.Q;



    private GameObject movableObject;


    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        string[] layers = { LayerName };
        if (Physics.Raycast(ray, out hit, visionLength, LayerMask.GetMask(layers)))
        {
            Debug.DrawRay(transform.position, Vector3.forward,Color.green);
            interactKey.gameObject.SetActive(true);
        }
        else
        {
            interactKey.gameObject.SetActive(false);
        }
    }
}
    



   //if(angle > visionLength* 0.5f)
   //     {
   //         interactKey.gameObject.SetActive(false);
   //     }