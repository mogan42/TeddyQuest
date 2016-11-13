using UnityEngine;
using System.Collections;

public class PedestalCheck1 : MonoBehaviour
{
    public float checkLength = 20.0f;
    private RaycastHit hit;


    // Update is called once per frame
    void Update ()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.up , out hit , checkLength ))
        {
            if(hit.gameObject.tag == "toy1")
            {
                Debug.DrawRay(transform.position, Vector3.up , Color.green , checkLength);

            }
        }

    }
}
