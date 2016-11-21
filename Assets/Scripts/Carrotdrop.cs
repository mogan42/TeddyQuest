using UnityEngine;
using System.Collections;

public class Carrotdrop : MonoBehaviour {

    public GameObject carrot, carrotCover, pillar, plateLight, lightS, aI, arrow;

    void OnTriggerEnter(Collider e)
    {
        if (e.tag == "Player")
        {
            carrotCover.SetActive(false);
            carrot.SetActive(true);
            plateLight.SetActive(true);
            lightS.SetActive(true);
            pillar.SetActive(true);
            //aI.SetActive(true);
            arrow.SetActive(true);
        }
    }
}
