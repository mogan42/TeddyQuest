using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public Text interactKey;
    public float visionWidth = 20f;
    public float visionLength = 10f;
    public float Force = 10.0f;
    private GameObject closestMoveable;
    public string Box = "box";

    // If this is changed make sure to change the canvas text
    public KeyCode Button = KeyCode.Q;



    private GameObject movableObject;

    //void Start()
    //{
    //    //interactKey.enabled = false;
    //}



    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        string[] layers = { "Interact" };
        var hits = Physics.OverlapSphere(transform.position, 10, LayerMask.GetMask(layers));
        foreach (Collider mo in hits)
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == mo.gameObject)
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
            
     
    }
}
    



   //if(angle > visionLength* 0.5f)
   //     {
   //         interactKey.gameObject.SetActive(false);
   //     }