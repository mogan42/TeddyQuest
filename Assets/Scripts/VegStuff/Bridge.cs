using UnityEngine;
using System.Collections;

public class Bridge : MonoBehaviour {

    public GameObject cubeBall, activationColour, bridgeA;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == cubeBall)
        {
            cubeBall.layer = 1;
            bridgeA.GetComponent<BoxCollider>().enabled = true;
            bridgeA.GetComponent<MeshRenderer>().enabled = true;
            cubeBall.tag = "Untagged";
            activationColour.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == cubeBall)
        {
            cubeBall.layer = 7;
            bridgeA.GetComponent<BoxCollider>().enabled = false;
            bridgeA.GetComponent<MeshRenderer>().enabled = false;
            cubeBall.tag = "box";
            activationColour.SetActive(false);
        }
    }
}
