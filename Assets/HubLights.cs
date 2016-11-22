using UnityEngine;
using System.Collections;

public class HubLights : MonoBehaviour
{
    public StartHubLights lights;
    void OnTriggerEnter()
    {
        lights.Lights();
    }
}
