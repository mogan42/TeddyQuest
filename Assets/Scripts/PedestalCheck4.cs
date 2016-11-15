using UnityEngine;
using System.Collections;

public class PedestalCheck4 : MonoBehaviour
{

    public PedestalDoorOpen PDO;

    public float checkLength = 20.0f;
    public GameObject toy4, floatingToy4;

    // Update is called once per frame
    void Update()
    {
        Vector3 up = transform.TransformDirection(Vector3.up);
        Debug.DrawRay(transform.position, up, Color.green);

        RaycastHit hit;

        if (Physics.Raycast(transform.position + transform.up * 0.5f, up, out hit, checkLength))
        {
            
            if (hit.transform.gameObject == toy4)
            {
                toy4.SetActive(false);
                floatingToy4.SetActive(true);
                PDO.CountIncrease();
            }

        }
    }
}
