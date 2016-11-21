using UnityEngine;
using System.Collections;

public class AAA : MonoBehaviour {

    public GameObject fadeP;
    public GameObject down, up;

    void OnTriggerEnter(Collider t)
    {
        if (t.tag == "Player")
        {
            fadeP.SetActive(true);
            down.SetActive(false);
            up.SetActive(true);
        }
    }
}
