using UnityEngine;
using System.Collections;

public class BridgeActivation : MonoBehaviour {

    public GameObject cubeBall, activationColour, bridgeA;


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == cubeBall)
        {
            cubeBall.layer = 1;
            cubeBall.tag = "Untagged";
            bridgeA.SetActive(true);
            activationColour.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == cubeBall)
        {
            cubeBall.layer = 7;
            cubeBall.tag = "box";
            activationColour.SetActive(false);
            bridgeA.SetActive(false);
        }
    }
}
