using UnityEngine;
using System.Collections;

public class Carrotdrop : MonoBehaviour {

    public GameObject carrot, carrotCover;
    public GameObject plateLight;

    void OnTriggerEnter(Collider e)
    {
        if (e.tag == "Player")
        {
            carrotCover.SetActive(false);
            carrot.SetActive(true);
            plateLight.SetActive(true);
        }
    }
}
