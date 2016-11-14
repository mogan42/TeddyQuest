using UnityEngine;
using System.Collections;

public class PedestalCheck1 : MonoBehaviour
{
    
    public float checkLength = 20.0f;
    public GameObject toy1, floatingToy1;

    // Update is called once per frame
    void Update ()
    {
        Vector3 up = transform.TransformDirection(Vector3.up);
        Debug.DrawRay(transform.position + transform.up * 0.5f, up, Color.green);

        RaycastHit hit;

        if (Physics.Raycast(transform.position + transform.up * 0.5f, up, out hit, checkLength))
        {
          
            if(hit.transform.gameObject == toy1)
            {
                toy1.SetActive(false);
                floatingToy1.SetActive(true);
                toy1.GetComponent<PedestalDoorOpen>();
            }
        }
    }
}


       //   PedestalDoorOpen

