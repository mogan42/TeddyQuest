using UnityEngine;
using System.Collections;

public class aiactivation : MonoBehaviour {

    public GameObject aI;
    public float delay = 2f;

    void OnTriggerEnter(Collider a)
    {
        if(a.tag == "Player")
        {
            aI.SetActive(true);
            Destroy(gameObject, delay);
        }
    }
}
