using UnityEngine;
using System.Collections;

public class HubLights : MonoBehaviour
{
    public GameObject Light1, Light2, Light3, Light4, Light5, Light6, Light7;
    public GameObject Morgan, Kaleb, Kristian;
    float TimeRun =1;
    bool startLights = false;
    bool startUp = true;
    public GlobalLog globalLog;

    void OnTriggerEnter()
    {
        startLights = true;
        Morgan.SetActive(false);
        Kaleb.SetActive(false);
        Kristian.SetActive(false);

    }
    void Update()
    {
        if(globalLog.numberOfKeys !=0)
        {
            startLights = true;
        }
        if (globalLog.amazonLibraryExit)
        {
            Morgan.SetActive(true);
        }
        if (globalLog.caveExit)
        {
            Kristian.SetActive(true);
        }
        if(globalLog.vegForestExit)
        {
            Kaleb.SetActive(true);
        }
        if(startUp)
        {
            Morgan.SetActive(false);
            Kaleb.SetActive(false);
            Kristian.SetActive(false);
            startUp = false;
        }
        if (startLights)
        {
            TimeRun += Time.deltaTime;
            Debug.Log(TimeRun);
            Light1.SetActive(true);
            if (TimeRun > 1)
            {
                Light2.SetActive(true);
            }
            if (TimeRun > 2)
            {
                Light3.SetActive(true);
            }
            if (TimeRun > 3)
            {
                Light4.SetActive(true);
            }
            if (TimeRun > 4)
            {
                Light5.SetActive(true);
            }
            if (TimeRun > 5)
            {
                Light6.SetActive(true);
            }
            if (TimeRun > 6)
            {
                Light7.SetActive(true);
            }
        }
    }
    void TurnOnLights()
    {

    }
}
